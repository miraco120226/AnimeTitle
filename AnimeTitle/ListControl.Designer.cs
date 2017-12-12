namespace AnimeTitle
{
    partial class ListControl
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
            this.Leftpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Middlepanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Rightpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.AutoSize = true;
            this.Leftpanel.BackColor = System.Drawing.Color.Red;
            this.Leftpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Margin = new System.Windows.Forms.Padding(0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(200, 400);
            this.Leftpanel.TabIndex = 3;
            // 
            // Middlepanel
            // 
            this.Middlepanel.AutoSize = true;
            this.Middlepanel.BackColor = System.Drawing.Color.Yellow;
            this.Middlepanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Middlepanel.Location = new System.Drawing.Point(200, 0);
            this.Middlepanel.Margin = new System.Windows.Forms.Padding(0);
            this.Middlepanel.Name = "Middlepanel";
            this.Middlepanel.Size = new System.Drawing.Size(20, 400);
            this.Middlepanel.TabIndex = 4;
            // 
            // Rightpanel
            // 
            this.Rightpanel.AutoSize = true;
            this.Rightpanel.BackColor = System.Drawing.Color.Blue;
            this.Rightpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Rightpanel.Location = new System.Drawing.Point(220, 0);
            this.Rightpanel.Margin = new System.Windows.Forms.Padding(0);
            this.Rightpanel.Name = "Rightpanel";
            this.Rightpanel.Size = new System.Drawing.Size(200, 400);
            this.Rightpanel.TabIndex = 4;
            // 
            // ListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Rightpanel);
            this.Controls.Add(this.Middlepanel);
            this.Controls.Add(this.Leftpanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListControl";
            this.Size = new System.Drawing.Size(420, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Leftpanel;
        private System.Windows.Forms.FlowLayoutPanel Middlepanel;
        private System.Windows.Forms.FlowLayoutPanel Rightpanel;
    }
}
