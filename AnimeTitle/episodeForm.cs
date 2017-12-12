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
    public partial class episodeForm : Form
    {

        string episode = null;
        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

        public episodeForm()
        {
            InitializeComponent();
        }

        public episodeForm(HtmlAgilityPack.HtmlDocument var)
        {
            InitializeComponent();
            doc = var;

            foreach(HtmlNode th in doc.DocumentNode.SelectNodes("//th"))
            {
                EpisodeListBox.Items.Add(th.InnerText);
            } 
        }

        private void select_Click(object sender, EventArgs e)
        {
            episode=EpisodeListBox.SelectedItem.ToString();
        }

         public string getEpisode()
        {
            return episode;
        }

    }

}
