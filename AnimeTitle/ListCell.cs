using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AnimeTitle
{
    public partial class ListCell : UserControl
    {
        public bool focus = false;
        public bool isLeft;
        protected ListControl lc;
        protected string text;
        protected string fullPath;
        protected string path;
        public static int width = 160;
        public static int height = 20;

        public ListCell()
        {
            InitializeComponent();
        }

        public ListCell(string input, ListControl owner,bool left)
        {
            InitializeComponent();
            Width = width;
            Height = height;
            editName.AutoSize = false;
            editName.Width = width;
            editName.Height = height;
            isLeft = left;
            fullPath = input;

            try
            {
                text = fullPath.Substring(fullPath.LastIndexOf(@"\")+1);
                path = fullPath.Remove(fullPath.LastIndexOf(@"\") + 1, text.Length);
            }
            catch
            {
                MessageBox.Show("檔案輸入錯誤");
                text = "null";
            }

            TextLabel.Text = text;
            editName.Text = text;
            lc = owner;

        }

        private void ListControl_Paint(object sender, PaintEventArgs e)
        {
            if (focus)
            {
                Pen p = new Pen(Color.FromArgb(0x89, 0xCA, 0xFF), 2);
                Graphics g = e.Graphics;
                g.DrawRectangle(p, new Rectangle(0, 0, this.Width, this.Height));
                this.BackColor = Color.FromArgb(0xCC, 0xE8, 0xFF);
            }
        }

        public void cleanFocus()
        {
            focus = false;
            BackColor = Color.White;
        }

        public void handle_Mouse(string type)
        {
            switch (type)
            {
                case "MouseDown":
                    if (focus)
                    {
                        BackColor = Color.White;
                    }
                    focus = !focus;
                    break;

                case "MouseEnter":
                    if (!focus)
                    {
                        BackColor = Color.FromArgb(0xE5, 0xF3, 0xFF);
                    }
                    break;

                case "MouseLeave":
                    if (!focus)
                    {
                        BackColor = Color.White;
                    }
            break;
            }
            Refresh();
        }

        public void rename()
        {
            TextLabel.Visible = false;
            TextLabel.Enabled = false;
            editName.Text = TextLabel.Text;
            editName.Visible = true;
            editName.Enabled = true;
        }

        public void canaelRename()
        {
            TextLabel.Visible = true;
            TextLabel.Enabled = true;
            editName.Text = TextLabel.Text;
            editName.Visible = false;
            editName.Enabled = false;
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

        public void Control_MouseDown(object sender, MouseEventArgs e)
        {
            lc.cleanAllFocus();
            handle_Mouse("MouseDown");
            Focus();
        }

        public void Control_MouseEnter(object sender, EventArgs e)
        {
            handle_Mouse("MouseEnter");
        }

        public void Control_MouseLeave(object sender, EventArgs e)
        {
            handle_Mouse("MouseLeave");
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

        private void ListCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Delete") )
            {
                
                int y = lc.owner.AutoScrollPosition.Y;
                ControlCollection left = lc.Controls[2].Controls;
                ControlCollection mid = lc.Controls[1].Controls;
                ControlCollection right = lc.Controls[0].Controls;

                if (right.Contains(this))
                {
                    int index = right.IndexOf(this);

                    if (right.Count > left.Count)
                    {
                        mid.RemoveAt(0);
                    }

                    lc.rightList.RemoveAt(index);
                    right.Remove(this);
                }
                else if (left.Contains(this))
                {
                    int index = left.IndexOf(this);

                    if (left.Count > right.Count)
                    {
                        mid.RemoveAt(0);
                    }

                    lc.leftList.RemoveAt(index);
                    left.Remove(this);
                }

                lc.owner.AutoScrollPosition = new Point(0, -y);
            }
        }
    }
}
