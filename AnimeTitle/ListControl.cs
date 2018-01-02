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
        int MiddleWidth = 40;
        public Panel owner;
        public CellManager cm;

        public ListControl(Panel p)
        {
            InitializeComponent();

            owner = p;

            LeftNumPanel.Width = N_ListCell.width;
            LeftNumPanel.Location = new Point(0, 0);
            LeftPanel.Width = L_ListCell.width;
            LeftPanel.Location = new Point(LeftNumPanel.Width, 0);
            MiddlePanel.Width = MiddleWidth;
            MiddlePanel.Location = new Point(LeftNumPanel.Width + LeftPanel.Width,0);
            RightPanel.Width = R_ListCell.width;
            RightPanel.Location = new Point(LeftNumPanel.Width + LeftPanel.Width + MiddlePanel.Width,0);

            Width = LeftNumPanel.Width + LeftPanel.Width + MiddlePanel.Width + RightPanel.Width;
            LeftNumPanel.Height = 0;
            LeftPanel.Height = 0;
            MiddlePanel.Height = 0;
            RightPanel.Height = 0;

            DoubleBuffered = true;
            PropertyInfo info0 = this.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            info0.SetValue(LeftNumPanel, true, null);
            PropertyInfo info1 = this.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            info1.SetValue(LeftPanel, true, null);
            PropertyInfo info2 = this.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            info2.SetValue(MiddlePanel, true, null);
            PropertyInfo info3 = this.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            info3.SetValue(RightPanel, true, null);
            setBackground(Color.FromArgb(200, 200, 200));

            cm = new CellManager(this,LeftNumPanel.Controls, LeftPanel.Controls, MiddlePanel.Controls, RightPanel.Controls);

            LeftPanel.Click += clickToCleanFocus;
            MiddlePanel.Click += clickToCleanFocus;
            RightPanel.Click += clickToCleanFocus;
            Click += clickToCleanFocus;
        }

        private void clickToCleanFocus(object sender, EventArgs e)
        {
            cm.cleanAllFocus();
        }

        public void setBackground(Color color)
        {
            LeftNumPanel.BackColor = color;
            LeftPanel.BackColor = color;
            MiddlePanel.BackColor = color;
            RightPanel.BackColor = color;
        }

    }
}
