namespace AnimeTitle
{
    partial class ListCell
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TextLabel = new System.Windows.Forms.Label();
            this.editName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextLabel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.TextLabel.Location = new System.Drawing.Point(0, 0);
            this.TextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(190, 25);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "text";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextLabel.DoubleClick += new System.EventHandler(this.TextLabel_DoubleClick);
            this.TextLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.TextLabel.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.TextLabel.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // editName
            // 
            this.editName.Enabled = false;
            this.editName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.editName.Location = new System.Drawing.Point(0, 0);
            this.editName.Margin = new System.Windows.Forms.Padding(0);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(112, 25);
            this.editName.TabIndex = 1;
            this.editName.Visible = false;
            this.editName.WordWrap = false;
            this.editName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editName_KeyDown);
            // 
            // ListCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.editName);
            this.Controls.Add(this.TextLabel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Name = "ListCell";
            this.Size = new System.Drawing.Size(190, 25);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ListControl_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListCell_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox editName;
    }
}
