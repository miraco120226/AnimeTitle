using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AnimeTitle
{
    public partial class ListControl : UserControl
    {
        public List<string> leftList;
        public List<string> rightList;
        int btnWidth = 40;
        public Panel owner;

        public ListControl(List<string> left, List<string> right, Panel p)
        {
            InitializeComponent();

            owner = p;

            Leftpanel.Width = ListCell.width;
            Middlepanel.Width = btnWidth;
            Middlepanel.Location = new Point(Leftpanel.Width,0);
            Rightpanel.Width = ListCell.width;
            Rightpanel.Location = new Point(Leftpanel.Width + Middlepanel.Width,0);
            Width = Leftpanel.Width + Middlepanel.Width + Rightpanel.Width;
            Leftpanel.Height = 0;
            Middlepanel.Height = 0;
            Rightpanel.Height = 0;
            DoubleBuffered = true;
            PropertyInfo info1 = this.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            info1.SetValue(Leftpanel, true, null);
            PropertyInfo info2 = this.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            info2.SetValue(Middlepanel, true, null);
            PropertyInfo info3 = this.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            info3.SetValue(Rightpanel, true, null);
            setBackground(Color.FromArgb(200, 200, 200));

            leftList = left;
            rightList = right;

            Leftpanel.Click += clickToCleanFocus;
            Middlepanel.Click += clickToCleanFocus;
            Rightpanel.Click += clickToCleanFocus;
            Click += clickToCleanFocus;
        }

        private void clickToCleanFocus(object sender, EventArgs e)
        {
            cleanAllFocus();
        }

        public List<ListCell> findNeighborCell(MiddleCell mc)
        {
            
            int index = Middlepanel.Controls.IndexOf(mc);

            List<ListCell> result = new List<ListCell>();

            result.Add(Leftpanel.Controls.Cast<ListCell>().ToList().ElementAtOrDefault(index));
            result.Add(Rightpanel.Controls.Cast<ListCell>().ToList().ElementAtOrDefault(index));

            return result;
        }

        public void Add(Control c,int location)
        {
            switch (location)
            {
                case 1:
                    Leftpanel.Controls.Add(c);
                    break;
                case 2:
                    Middlepanel.Controls.Add(c);
                    break;
                case 3:
                    Rightpanel.Controls.Add(c);
                    break;
            }
        }

        public void cleanAllFocus()
        {
            foreach (L_ListCell llc in Leftpanel.Controls)
            {
                if (llc.focus)
                {
                    llc.cleanFocus();
                    llc.Refresh();
                }
            }
            foreach (R_ListCell rlc in Rightpanel.Controls)
            {
                if (rlc.focus)
                {
                    rlc.cleanFocus();
                    rlc.canaelRename();
                    rlc.Refresh();
                }
            }
        }

        public void setBackground(Color color)
        {
            Leftpanel.BackColor = color;
            Middlepanel.BackColor = color;
            Rightpanel.BackColor = color;
        }

        public void refresh()
        {
            Leftpanel.Controls.Clear();
            foreach (string str in leftList)
            {
                L_ListCell lc = new L_ListCell(str, this);
                Add(lc, 1);
            }

            Middlepanel.Controls.Clear();
            for (int i = 0; i < Math.Max(leftList.Count, rightList.Count); i++)
            {
                MiddleCell mc = new MiddleCell(this);
                Add(mc, 2);
            }

            Rightpanel.Controls.Clear();
            foreach (string str in rightList)
            {
                R_ListCell lc = new R_ListCell(str, this);
                Add(lc, 3);
            }
        }

        public void refresh(int location)
        {
            if (location == 1)
            {
                Leftpanel.Controls.Clear();
                foreach (string str in leftList)
                {
                    L_ListCell lc = new L_ListCell(str, this);
                    Add(lc, 1);
                }
            }
            else if (location == 2)
            {
                Rightpanel.Controls.Clear();
                foreach (string str in rightList)
                {
                    R_ListCell lc = new R_ListCell(str, this);
                    Add(lc, 3);
                }
            }

            int max = Math.Max(Leftpanel.Controls.Count, Rightpanel.Controls.Count);

            if (Middlepanel.Controls.Count > max)
            {
                Middlepanel.Controls.RemoveAt(Middlepanel.Controls.Count - 1);
            }
        }

        public void renameSelectedCell()
        {
            foreach(R_ListCell rlc in Rightpanel.Controls)
            {
                if (rlc.focus)
                {
                    rlc.rename();
                }
            }
        }

        public ListCell getFocusCell()
        {
            List<ListCell> total = new List<ListCell>();
            total.AddRange(Leftpanel.Controls.Cast<ListCell>());
            total.AddRange(Rightpanel.Controls.Cast<ListCell>());
            foreach (ListCell lc in total)
            {
                if (lc.focus)
                {
                    return lc;
                }
            }

            return null;
        }

    }
}
