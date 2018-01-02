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
        public CellManager cm;
        protected ListControl lco;
        protected string text;

        public ListCell()
        {
            InitializeComponent();
            editName.AutoSize = false;
            editName.Text = text;
        }

        private void ListCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Delete"))
            {
                int y = lco.owner.AutoScrollPosition.Y;

                if (this is L_ListCell)
                {
                    cm.deleteCell(this as L_ListCell);
                }
                else if (this is R_ListCell)
                {
                    cm.deleteCell(this as R_ListCell);
                }

                lco.owner.AutoScrollPosition = new Point(0, -y);
            }
        }

        private void editName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                e.SuppressKeyPress = true;
                handleRename();
                TextLabel.Visible = true;
                TextLabel.Enabled = true;
                editName.Visible = false;
                editName.Enabled = false;
            }
        }

        protected virtual void handleRename()
        {

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

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            cm.cleanAllFocus();
            handle_Mouse("MouseDown");
            Focus();
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            handle_Mouse("MouseEnter");
        }

        private void Control_MouseLeave(object sender, EventArgs e)
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
