using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeTitle
{
    public partial class MiddleCell : UserControl
    {
        ListControl lc;

        public MiddleCell(ListControl owner)
        {
            InitializeComponent();
            lc = owner;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Refresh();
            List<ListCell> lcList = lc.findNeighborCell(this);
            foreach (ListCell lc in lcList)
            {
                if (lc != null)
                {
                    lc.handle_Mouse("MouseLeave");
                }
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0xE5, 0xF3, 0xFF);
            Refresh();
            List<ListCell> lcList = lc.findNeighborCell(this);
            foreach (ListCell lc in lcList)
            {
                if (lc != null)
                {
                    lc.handle_Mouse("MouseEnter");
                }
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lc.cleanAllFocus();
        }
    }
}
