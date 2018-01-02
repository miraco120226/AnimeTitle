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
            this.LeftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MiddlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RightPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftNumPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoSize = true;
            this.LeftPanel.BackColor = System.Drawing.Color.Red;
            this.LeftPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LeftPanel.Location = new System.Drawing.Point(30, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 400);
            this.LeftPanel.TabIndex = 3;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.AutoSize = true;
            this.MiddlePanel.BackColor = System.Drawing.Color.Yellow;
            this.MiddlePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MiddlePanel.Location = new System.Drawing.Point(230, 0);
            this.MiddlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(20, 400);
            this.MiddlePanel.TabIndex = 4;
            // 
            // RightPanel
            // 
            this.RightPanel.AutoSize = true;
            this.RightPanel.BackColor = System.Drawing.Color.Blue;
            this.RightPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RightPanel.Location = new System.Drawing.Point(250, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(200, 400);
            this.RightPanel.TabIndex = 4;
            // 
            // LeftNumPanel
            // 
            this.LeftNumPanel.AutoSize = true;
            this.LeftNumPanel.BackColor = System.Drawing.Color.GreenYellow;
            this.LeftNumPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LeftNumPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftNumPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftNumPanel.Name = "LeftNumPanel";
            this.LeftNumPanel.Size = new System.Drawing.Size(30, 400);
            this.LeftNumPanel.TabIndex = 4;
            // 
            // ListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LeftNumPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.LeftPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListControl";
            this.Size = new System.Drawing.Size(450, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel LeftPanel;
        private System.Windows.Forms.FlowLayoutPanel MiddlePanel;
        private System.Windows.Forms.FlowLayoutPanel RightPanel;
        private System.Windows.Forms.FlowLayoutPanel LeftNumPanel;
    }
}
