using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeTitle
{
    public partial class TableForm : Form
    {

        string title = null;
        public HtmlAgilityPack.HtmlDocument orig_doc = new HtmlAgilityPack.HtmlDocument();
        public HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        public HtmlNode titleNode = null;
        int index = 0;

        public TableForm()
        {
            InitializeComponent();
        }

        public TableForm(HtmlAgilityPack.HtmlDocument var)
        {
            InitializeComponent();
            initForm(var);
        }

        public void initForm(HtmlAgilityPack.HtmlDocument var)
        {
            orig_doc = var;
            doc.LoadHtml(var.DocumentNode.OuterHtml.Replace("\r\n",string.Empty).Replace("\n", string.Empty));
            for (int i=1 ;doc.DocumentNode.SelectSingleNode("//table["+i+"]")!=null ;i++)
            {
                if(doc.DocumentNode.SelectSingleNode("//table[" + i + "]//th[1]") == null)
                {
                    TableListBox.Items.Add(doc.DocumentNode.SelectSingleNode("//table[" + i + "]").InnerHtml);
                }
                else
                {
                    TableListBox.Items.Add(doc.DocumentNode.SelectSingleNode("//table[" + i + "]//th[1]").InnerText);
                }
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            titleNode = orig_doc.DocumentNode.SelectSingleNode("//table[" + index + "]");
        }

        private void TitleListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            index = TableListBox.SelectedIndex + 1;
            title = doc.DocumentNode.SelectSingleNode("//table[" + index + "]").InnerHtml;
            webBrowser1.DocumentText = "<table border=\"1px solid #a2a9b1\">" + title + "</table>"; ;
        }

        private void setPage_Click(object sender, EventArgs e)
        {
            FindPage fp = new FindPage(((AnimeTitle)Owner).url);
            fp.StartPosition = FormStartPosition.CenterParent;
            fp.Owner = this;
            if (fp.ShowDialog() == DialogResult.OK)
            {
                orig_doc = fp.newdoc;
                doc.LoadHtml(fp.newdoc.DocumentNode.OuterHtml.Replace("\n", ""));
                initForm(doc);
            }
        }
    }
}
