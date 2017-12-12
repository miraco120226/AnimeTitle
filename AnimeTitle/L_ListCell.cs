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

        public L_ListCell()
        {
            InitializeComponent();
        }

        public L_ListCell(string input, ListControl owner)
        {
            TextLabel = GetTextLabel();
            lc = owner;
            text = input;
            TextLabel.Text = text;
            KeyDown += ListCell_KeyDown;
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
    }
}
