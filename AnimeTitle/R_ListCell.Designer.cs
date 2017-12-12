namespace AnimeTitle
{
    partial class R_ListCell
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.editName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editName
            // 
            this.editName.Enabled = false;
            this.editName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.editName.Location = new System.Drawing.Point(0, 0);
            this.editName.Margin = new System.Windows.Forms.Padding(0);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(160, 25);
            this.editName.TabIndex = 2;
            this.editName.Visible = false;
            this.editName.WordWrap = false;
            this.editName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editName_KeyDown);
            // 
            // R_ListCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.editName);
            this.Name = "R_ListCell";
            this.Controls.SetChildIndex(this.editName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editName;
    }
}
