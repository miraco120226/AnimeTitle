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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.AllowDrop = true;
            this.LeftPanel.AutoSize = true;
            this.LeftPanel.BackColor = System.Drawing.Color.Red;
            this.LeftPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LeftPanel.Location = new System.Drawing.Point(35, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPanel.MinimumSize = new System.Drawing.Size(200, 50);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LeftPanel.Size = new System.Drawing.Size(200, 50);
            this.LeftPanel.TabIndex = 4;
            this.LeftPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.LeftPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.LeftPanel_DragEnter);
            this.LeftPanel.DragLeave += new System.EventHandler(this.LeftPanel_DragLeave);
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.AutoSize = true;
            this.MiddlePanel.BackColor = System.Drawing.Color.Yellow;
            this.MiddlePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MiddlePanel.Location = new System.Drawing.Point(235, 0);
            this.MiddlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.MiddlePanel.MinimumSize = new System.Drawing.Size(40, 50);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.MiddlePanel.Size = new System.Drawing.Size(40, 50);
            this.MiddlePanel.TabIndex = 4;
            // 
            // RightPanel
            // 
            this.RightPanel.AllowDrop = true;
            this.RightPanel.AutoSize = true;
            this.RightPanel.BackColor = System.Drawing.Color.Blue;
            this.RightPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RightPanel.Location = new System.Drawing.Point(275, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RightPanel.MinimumSize = new System.Drawing.Size(200, 50);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.RightPanel.Size = new System.Drawing.Size(200, 50);
            this.RightPanel.TabIndex = 4;
            this.RightPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.RightPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.RightPanel_DragEnter);
            this.RightPanel.DragLeave += new System.EventHandler(this.RightPanel_DragLeave);
            this.RightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // LeftNumPanel
            // 
            this.LeftNumPanel.AutoSize = true;
            this.LeftNumPanel.BackColor = System.Drawing.Color.GreenYellow;
            this.LeftNumPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LeftNumPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftNumPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftNumPanel.MinimumSize = new System.Drawing.Size(35, 50);
            this.LeftNumPanel.Name = "LeftNumPanel";
            this.LeftNumPanel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.LeftNumPanel.Size = new System.Drawing.Size(35, 50);
            this.LeftNumPanel.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.LeftNumPanel);
            this.flowLayoutPanel1.Controls.Add(this.LeftPanel);
            this.flowLayoutPanel1.Controls.Add(this.MiddlePanel);
            this.flowLayoutPanel1.Controls.Add(this.RightPanel);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 400);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // ListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListControl";
            this.Size = new System.Drawing.Size(475, 400);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel LeftPanel;
        private System.Windows.Forms.FlowLayoutPanel MiddlePanel;
        private System.Windows.Forms.FlowLayoutPanel RightPanel;
        private System.Windows.Forms.FlowLayoutPanel LeftNumPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
