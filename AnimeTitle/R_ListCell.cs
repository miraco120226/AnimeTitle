using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AnimeTitle
{
    public partial class R_ListCell : AnimeTitle.ListCell
    {
        public static int width = 200;
        public static int height = 20;
        Label TextLabel;
        TextBox editName;
        string fullPath;
        string path;

        public R_ListCell()
        {
            InitializeComponent();
        }

        public R_ListCell(string input, ListControl owner)
        {
            TextLabel = GetTextLabel();
            editName = GetEditLabel();

            Width = width;
            Height = height;
            editName.Width = width;
            editName.Height = height;

            fullPath = input;

            try
            {
                text = fullPath.Substring(fullPath.LastIndexOf(@"\") + 1);
                path = fullPath.Remove(fullPath.LastIndexOf(@"\") + 1, text.Length);
            }
            catch
            {
                MessageBox.Show("檔案輸入錯誤");
                text = "null";
            }

            lco = owner;
            cm = owner.cm;
            TextLabel.Text = text;
            TextLabel.DoubleClick += TextLabel_DoubleClick;
        }

        public bool renameFile(string newName)
        {
            if (!(File.Exists(fullPath)))
            {
                MessageBox.Show("檔案不存在");
                return false;
            }
            else
            {
                try
                {
                    File.Move(fullPath, path + newName);
                }
                catch
                {
                    MessageBox.Show("重新命名失敗");
                    return false;
                }
            }

            return true;
        }

        private void TextLabel_DoubleClick(object sender, EventArgs e)
        {
            Environment.GetFolderPath(Environment.SpecialFolder.System);
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = fullPath;
            pInfo.UseShellExecute = true;
            try
            {
                Process p = Process.Start(pInfo);
            }
            catch
            {
                MessageBox.Show("開啟錯誤");
            }
        }

        protected override void handleRename()
        {
            if (renameFile(editName.Text))
            {
                fullPath = path + editName.Text;
                text = editName.Text;
                TextLabel.Text = editName.Text;
            }
        }
    }
}
