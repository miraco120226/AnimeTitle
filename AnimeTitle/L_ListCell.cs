using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimeTitle
{
    public partial class L_ListCell : AnimeTitle.ListCell
    {
        Label TextLabel;
        TextBox editName;

        public L_ListCell()
        {
            InitializeComponent();
        }

        public L_ListCell(string input, ListControl owner)
        {
            TextLabel = GetTextLabel();
            editName = GetEditLabel();
            lc = owner;
            text = input;
            TextLabel.Text = text;
            KeyDown += ListCell_KeyDown;
            editName.KeyDown += editName_KeyDown;
        }

        private void ListCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Delete"))
            {
                int y = lc.owner.AutoScrollPosition.Y;
                ControlCollection left = lc.Controls[2].Controls;
                ControlCollection mid = lc.Controls[1].Controls;
                ControlCollection right = lc.Controls[0].Controls;
                int index = left.IndexOf(this);

                if (left.Count > right.Count)
                {
                    mid.RemoveAt(0);
                }

                lc.leftList.RemoveAt(index);
                left.Remove(this);

                lc.owner.AutoScrollPosition = new Point(0, -y);
            }
        }

        private void editName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                e.SuppressKeyPress = true;
                ControlCollection left = lc.Controls[2].Controls;
                int index = left.IndexOf(this);

                lc.leftList[index] = editName.Text;
                text = editName.Text;
                TextLabel.Text = editName.Text;

                TextLabel.Visible = true;
                TextLabel.Enabled = true;
                editName.Visible = false;
                editName.Enabled = false;
            }
        }
    }
}
