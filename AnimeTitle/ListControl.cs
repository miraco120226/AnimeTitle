﻿using System;
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
        public bool onDrag = false;
        Rectangle rec;

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
            //setBackground(Color.FromArgb(200, 200, 200));
            setBackground(Color.White);

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

        private void LeftPanel_DragEnter(object sender, DragEventArgs e)
        {
            Point p = PointToClient(new Point(e.X, e.Y));
            Control ctrl = e.Data.GetData(e.Data.GetFormats(true)[0]) as Control;
            if (ctrl is L_ListCell)
            {
                e.Effect = DragDropEffects.Move;
                rec = new Rectangle(0, p.Y - 2, LeftPanel.Width, 4);
                onDrag = true;
                LeftPanel.Refresh();
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void RightPanel_DragEnter(object sender, DragEventArgs e)
        {
            
            Point p = PointToClient(new Point(e.X, e.Y));
            Control ctrl = e.Data.GetData(e.Data.GetFormats(true)[0]) as Control;
            if (ctrl is R_ListCell)
            {
                e.Effect = DragDropEffects.Move;
                rec = new Rectangle(0, p.Y - 2, RightPanel.Width, 4);
                onDrag = true;
                RightPanel.Refresh();
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (onDrag)
            {
                g.FillRectangle(Brushes.Gray, rec);
            }
            else
            {
                g.FillRectangle(Brushes.Transparent, rec);
            }
        }

        public void Panel_DragDrop(object sender, DragEventArgs e)
        {
            Control ctrl = e.Data.GetData(e.Data.GetFormats(true)[0]) as Control;

            if (onDrag)
            {
                int scroll_y = owner.AutoScrollPosition.Y;

                int y = rec.Y + 2;
                int index = ((y + 1) / 2) / 11;
                onDrag = false;

                if (ctrl is L_ListCell)
                {
                    cm.moveCell(ctrl as L_ListCell, index);
                }
                else if (ctrl is R_ListCell)
                {
                    cm.moveCell(ctrl as R_ListCell, index);
                }
                
                owner.AutoScrollPosition = new Point(0, -scroll_y);
            }
        }

        private void LeftPanel_DragLeave(object sender, EventArgs e)
        {
            onDrag = false;
            LeftPanel.Refresh();
        }

        private void RightPanel_DragLeave(object sender, EventArgs e)
        {
            onDrag = false;
            RightPanel.Refresh();
        }
        
    }
}
