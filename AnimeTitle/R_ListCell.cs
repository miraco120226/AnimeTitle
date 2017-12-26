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
            InitializeComponent();
            TextLabel = GetTextLabel();
            editName = GetEditLabel();
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

            lc = owner;
            TextLabel.Text = text;
            TextLabel.DoubleClick += TextLabel_DoubleClick;
            KeyDown += ListCell_KeyDown;
            editName.KeyDown += editName_KeyDown;
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
            Console.WriteLine("rlc");
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

        private void ListCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Delete"))
            {
                int y = lc.owner.AutoScrollPosition.Y;
                ControlCollection left = lc.Controls[2].Controls;
                ControlCollection mid = lc.Controls[1].Controls;
                ControlCollection right = lc.Controls[0].Controls;
                int index = right.IndexOf(this);

                if (right.Count > left.Count)
                {
                    mid.RemoveAt(0);
                }

                lc.rightList.RemoveAt(index);
                right.Remove(this);

                lc.owner.AutoScrollPosition = new Point(0, -y);
            }
        }

        private void editName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                e.SuppressKeyPress = true;
                if (renameFile(editName.Text))
                {
                    fullPath = path + editName.Text;
                    text = editName.Text;
                    TextLabel.Text = editName.Text;
                }
                TextLabel.Visible = true;
                TextLabel.Enabled = true;
                editName.Visible = false;
                editName.Enabled = false;
            }
        }
    }
}
