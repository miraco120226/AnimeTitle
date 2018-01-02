using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimeTitle
{
    public partial class N_ListCell : AnimeTitle.ListCell
    {
        public static int width = 35;
        public static int height = 20;
        Label TextLabel;
        TextBox editName;

        public N_ListCell()
        {
            InitializeComponent();
        }

        public N_ListCell(Double input, ListControl owner)
        {
            TextLabel = GetTextLabel();
            editName = GetEditLabel();

            Width = width;
            Height = height;
            editName.Width = width;
            editName.Height = height;

            lco = owner;
            cm = owner.cm;
            text = input.ToString();
            TextLabel.Text = text;
            TextLabel.DoubleClick += TextLabel_DoubleClick;
        }

        public double getNum()
        {
            return double.Parse(text);
        }

        public void setNum(double num)
        {
            text = num.ToString();
            TextLabel.Text = num.ToString();
        }

        protected override void handleRename()
        {
            if (cm.checkLeftNumRename(this, editName.Text))
            {
                text = editName.Text;
                TextLabel.Text = editName.Text;
                cm.handleLeftNumCell(this);
            }
        }

        private void TextLabel_DoubleClick(object sender, EventArgs e)
        {
            rename();
        }
    }
}
