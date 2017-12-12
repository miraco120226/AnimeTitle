using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace AnimeTitle
{
    public partial class Form1 : Form
    {
        List<string> episode = new List<string>();
        List<string> cht_Title = new List<string>();
        List<string> left = new List<string>();
        List<string> right = new List<string>();
        String[] title_text = { "各話標題", "各話列表", "各話製作資料" , "各集列表" , "各集標題", "各集製作資料" };
        String[] episode_text = { "話數", "播放話數", "集數", "播放集數" };
        String[] chtTitle_text = { "台灣翻譯", "中文副標題", "中文標題" , "中文翻譯", "台灣副標題", "台灣標題" };
        public string url = "";
        public string getdata = "";
        ListControl lco;

        public Form1()
        {
            InitializeComponent();


            right.Add(@"D:\PICO\ccc\aaa.jpg");
            right.Add(@"C:\ddd.mkv");

            lco = new ListControl(left, right, listPanel);
            lco.refresh();
            listPanel.Controls.Add(lco);
            listPanel.Width = lco.Width+18;
            listPanel.AutoScrollMinSize = new Size(lco.Width, listPanel.Height+1);
        }

        private string getTableString(string htmlData)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlData);
            HtmlNode titleTable= removeSpaceAndNewLine(handleTitleText(doc));

            return titleTable.InnerHtml;
        }

        private HtmlNode removeSpaceAndNewLine(HtmlNode input)
        {
            var xpath = "//text()[not(normalize-space())]";
            var emptyNodes = input.SelectNodes(xpath);

            //replace each and all empty text nodes with single new-line text node
            foreach (HtmlNode emptyNode in emptyNodes)
            {
                emptyNode.ParentNode
                         .ReplaceChild(HtmlTextNode.CreateNode(Environment.NewLine),emptyNode);
            }
            //remove NewLine
            input.InnerHtml = input.InnerHtml.Replace("\r\n", string.Empty);

            return input;
        }

        private string normalizeTable(string htmlData)
        {
            //***********************************handle colspan***********************************
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml("<table border=\"1px solid #a2a9b1\">" + htmlData.Replace("\n", "")+ "</table>");

            foreach (HtmlNode td in doc.DocumentNode.SelectNodes("//td"))
            {
                if (!td.GetAttributeValue("colspan", "1").Equals("1"))
                {
                    int colspan = Convert.ToInt32(td.GetAttributeValue("colspan", "1"));
                    td.Attributes.Remove("colspan");
                    for (int i = 1; i < colspan; i++)
                    {
                        td.ParentNode.InsertAfter(td.Clone(), td);
                    }
                }
            }
            //***********************************handle colspan***********************************

            //***********************************handle rowspan***********************************
            List<KeyValuePair<int, HtmlNode>> rowspanList = new List<KeyValuePair<int, HtmlNode>>();

            foreach (HtmlNode td in doc.DocumentNode.SelectNodes("//td"))
            {
                if (!td.GetAttributeValue("rowspan", "1").Equals("1"))
                {
                    int col= td.ParentNode.ChildNodes.IndexOf(td);
                    int row = td.ParentNode.ParentNode.ChildNodes.IndexOf(td.ParentNode);
                    rowspanList.Add(new KeyValuePair<int, HtmlNode>(col*1000+row,td));
                   
                }
            }

            rowspanList.Sort(
                delegate (KeyValuePair<int, HtmlNode> pair1,
                KeyValuePair<int, HtmlNode> pair2)
                        {
                            return pair1.Key.CompareTo(pair2.Key);
                        }
            );

            foreach (KeyValuePair < int, HtmlNode > kp in rowspanList)
            {
                handleRowspan(kp.Value);
            }
            //***********************************handle rowspan***********************************

            return doc.DocumentNode.OuterHtml;
        }

        private void handleRowspan(HtmlNode td)
        {
            int index = td.ParentNode.ChildNodes.IndexOf(td);
            int rowspan = Convert.ToInt32(td.GetAttributeValue("rowspan", "1"));
            td.Attributes.Remove("rowspan");
            HtmlNode tr = td.ParentNode.NextSibling;
            for (int i = 1; i < rowspan; i++)
            {
                if (index == 0)
                {
                    tr.InsertBefore(td, tr.ChildNodes[0]);
                }
                else
                {
                    tr.InsertAfter(td, tr.ChildNodes[index - 1]);
                }
                tr = tr.NextSibling;
            }
        }

        private void parseTable(string htmlData)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlData);
            List<string> table = new List<string>();

            //HtmlNode episodeNode = doc.DocumentNode.SelectSingleNode("//th[text() = '話數']");
            HtmlNode episodeNode = handleEpisodeText(doc);
            int episodeIndex = doc.DocumentNode.SelectNodes("//th").IndexOf(episodeNode) + 1;

            //HtmlNode chtTitleNode = doc.DocumentNode.SelectSingleNode("//th[text() = '台灣翻譯']");
            HtmlNode chtTitleNode = handleChtTitleText(doc);
            int titleIndex = doc.DocumentNode.SelectNodes("//th").IndexOf(chtTitleNode) + 1;

            foreach (HtmlNode roll in doc.DocumentNode.SelectNodes("//tr//td[" + episodeIndex + "]"))
            {
                episode.Add(roll.InnerText);
            }

            foreach (HtmlNode roll in doc.DocumentNode.SelectNodes("//tr//td["+ titleIndex +"]"))
            {
                cht_Title.Add(roll.InnerText);
            }
        }

        private HtmlNode handleTitleText(HtmlAgilityPack.HtmlDocument doc)
        {
            HtmlNode titleTable = null;

            for (int i = 0; i < title_text.Length; i++)
            {
                if (doc.GetElementbyId(title_text[i]) != null)
                {
                    titleTable = doc.GetElementbyId(title_text[i]).ParentNode;
                    while (titleTable.Name != "table")
                    {
                        titleTable = titleTable.NextSibling;
                    }
                    break;
                }
            }

            if (titleTable == null)
            {
                FindPage fp = new FindPage(url);
                fp.StartPosition = FormStartPosition.CenterParent;
                fp.Owner = this;
                if (fp.ShowDialog() == DialogResult.OK)
                {
                    titleTable = fp.titleNode;
                }
            }

            return titleTable;
        }

        private HtmlNode handleEpisodeText(HtmlAgilityPack.HtmlDocument doc)
        {
            HtmlNode episodeNode = null;

            for (int i = 0; i < episode_text.Length; i++)
            {
                episodeNode = doc.DocumentNode.SelectSingleNode("//th[text() = '" + episode_text[i] + "']");
                if (episodeNode != null)
                {
                    return episodeNode;
                }
            }

            if (episodeNode == null)
            {
                episodeForm ef = new episodeForm(doc);
                ef.StartPosition = FormStartPosition.CenterParent;

                if (ef.ShowDialog() == DialogResult.OK)
                {
                    episodeNode = doc.DocumentNode.SelectSingleNode("//th[text() = '" + ef.getEpisode() + "']");
                }
            }

            return episodeNode;
        }

        private HtmlNode handleChtTitleText(HtmlAgilityPack.HtmlDocument doc)
        {
            HtmlNode chtTitleNode = null;

            for (int i = 0; i < chtTitle_text.Length; i++)
            {
                chtTitleNode = doc.DocumentNode.SelectSingleNode("//th[text() = '" + chtTitle_text[i] + "']");
                if (chtTitleNode != null)
                {
                    break;
                }
            }

            if (chtTitleNode == null)
            {
                TitleForm tf = new TitleForm(doc);
                tf.StartPosition = FormStartPosition.CenterParent;

                if (tf.ShowDialog() == DialogResult.OK)
                {
                    chtTitleNode = doc.DocumentNode.SelectSingleNode("//th[text() = '" + tf.getTitle() + "']");
                }
            }

            return chtTitleNode;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchName.Text.Length == 0)
            {
                return;
            }

            url = "https://zh.wikipedia.org/wiki/"+ searchName.Text;
            
            try
            {
                HttpWebRequest MyHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse MyHttpWebResponse = (HttpWebResponse)MyHttpWebRequest.GetResponse();
                Stream MyStream = MyHttpWebResponse.GetResponseStream();
                StreamReader MyStreamReader = new StreamReader(MyStream, Encoding.GetEncoding("UTF-8"));
                getdata = MyStreamReader.ReadToEnd();
                MyStreamReader.Close();
                MyStream.Close();
            }
            catch
            {

            }

            MessageBox.Show("OK");

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(getdata);

            episode.Clear();
            cht_Title.Clear();
            listView1.Items.Clear();

            try
            {
                parseTable(normalizeTable(getTableString(getdata)));

                for (int i = 0; i < episode.Count; i++)
                {
                    listView1.Items.Add(episode.ElementAt(i));
                    listView1.Items[i].SubItems.Add(cht_Title.ElementAt(i));
                }

            }
            catch
            {
                MessageBox.Show("發生錯誤");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem selected in listView1.SelectedItems)
            {
                Console.WriteLine();
                left.Add(selected.SubItems[1].Text);
            }
            lco.refresh();
        }

        private void addAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                Console.WriteLine();
                left.Add(item.SubItems[1].Text);
            }
            lco.refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Console.WriteLine(e.KeyCode);
            if (e.KeyCode.ToString().Equals("F2"))
            {
                ((ListControl)listPanel.Controls[0]).renameSelectedCell();
            }
            if (e.KeyCode.ToString().Equals("Delete"))
            {
                //if (ActiveControl.GetType().ToString().Equals("AnimeTitle.ListControl") && ((ListControl)listPanel.Controls[0]).getFocusCell()!=null)
                //{
                //    Console.WriteLine(((ListControl)listPanel.Controls[0]).getFocusCell().focus);
                //}
            }
            if (e.KeyCode.ToString().Equals("C"))
            {

            }
        }

        private void addfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string str in openFileDialog1.FileNames)
                {
                    if (str.Contains(@"\")){

                    }
                    else if (str.Contains(@"/"))
                    {
                        str.Replace(@"/", @"\");
                    }
                    else
                    {
                        MessageBox.Show("檔案輸入錯誤");
                        return;
                    }

                    right.Add(str);
                    lco.refresh();
                    Console.WriteLine(str);
                }
            }
        }
    }
}
