using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimeTitle
{
    public partial class L_ListCell : global::AnimeTitle.ListCell
    {
        public static int width = 200;
        public static int height = 20;
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

            MinimumSize = new Size(width, height);
            setSize(width, height);

            lco = owner;
            cm = owner.cm;
            text = input;
            TextLabel.Text = text;
            TextLabel.DoubleClick += TextLabel_DoubleClick;
        }

        protected override void handleRename()
        {
            text = editName.Text;
            TextLabel.Text = editName.Text;
        }

        private void TextLabel_DoubleClick(object sender, EventArgs e)
        {
            rename();
        }
    }
}
