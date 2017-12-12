using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimeTitle
{
    public partial class R_ListCell : AnimeTitle.ListCell
    {
        public R_ListCell()
        {
            InitializeComponent();
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
    }
}
