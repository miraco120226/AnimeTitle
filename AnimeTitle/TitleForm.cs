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
    public partial class TitleForm : Form
    {

        string title = null;
        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

        public TitleForm()
        {
            InitializeComponent();
        }

        public TitleForm(HtmlAgilityPack.HtmlDocument var)
        {
            InitializeComponent();
            doc = var;

            foreach (HtmlNode th in doc.DocumentNode.SelectNodes("//th"))
            {
                TitleListBox.Items.Add(th.InnerText);
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            title = TitleListBox.SelectedItem.ToString();
        }

        public string getTitle()
        {
            return title;
        }

    }
}
