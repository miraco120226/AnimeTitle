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
    public partial class FindPage : Form
    {
        public HtmlAgilityPack.HtmlDocument newdoc = new HtmlAgilityPack.HtmlDocument();
        public HtmlAgilityPack.HtmlNode titleNode = null;

        public FindPage()
        {
            InitializeComponent();
        }

        public FindPage(string url)
        {
            InitializeComponent();
            webBrowser1.Url = new Uri(url);
        }

        private void back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void next_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.MaximumProgress;
            progressBar1.Minimum = 0;
            if ((e.CurrentProgress >= progressBar1.Minimum) && (e.CurrentProgress <= progressBar1.Maximum))
            {
                progressBar1.Value = (int)e.CurrentProgress;
            }
        }

        private void FindPage_Resize(object sender, EventArgs e)
        {
            select.Location = new Point(FindPage.ActiveForm.Width - 180, select.Location.Y);
            webBrowser1.Size = new Size(FindPage.ActiveForm.Width - 60, FindPage.ActiveForm.Height - 130);
            progressBar1.Location = new Point(progressBar1.Location.X, FindPage.ActiveForm.Height - 60);
            progressBar1.Size = new Size(FindPage.ActiveForm.Width - 60, progressBar1.Height);
        }

        private void select_Click(object sender, EventArgs e)
        {
            newdoc.LoadHtml(webBrowser1.DocumentText);
            TableForm tf = new TableForm(newdoc);
            tf.StartPosition = FormStartPosition.CenterParent;
            tf.Owner = this;
            var tmp = tf.ShowDialog();
            if (tmp == DialogResult.OK)
            {
                titleNode = tf.titleNode;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
