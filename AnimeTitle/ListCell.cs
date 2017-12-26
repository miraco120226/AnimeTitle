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
        public static int width = 160;
        public static int height = 20;

        public ListCell()
        {
            InitializeComponent();
            Width = width;
            Height = height;

            editName.AutoSize = false;
            editName.Width = width;
            editName.Height = height;
            editName.Text = text;
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

        protected Label GetTextLabel()
        {
            return TextLabel;
        }

        protected TextBox GetEditLabel()
        {
            return editName;
        }

    }
}
