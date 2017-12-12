namespace AnimeTitle
{
    partial class episodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.select = new System.Windows.Forms.Button();
            this.EpisodeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // select
            // 
            this.select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.select.Font = new System.Drawing.Font("新細明體", 10F);
            this.select.Location = new System.Drawing.Point(65, 273);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(140, 30);
            this.select.TabIndex = 0;
            this.select.Text = "選擇";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // EpisodeListBox
            // 
            this.EpisodeListBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.EpisodeListBox.FormattingEnabled = true;
            this.EpisodeListBox.ItemHeight = 20;
            this.EpisodeListBox.Location = new System.Drawing.Point(25, 50);
            this.EpisodeListBox.Name = "EpisodeListBox";
            this.EpisodeListBox.Size = new System.Drawing.Size(220, 204);
            this.EpisodeListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "episode找不到，請選擇episode之欄位";
            // 
            // episodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EpisodeListBox);
            this.Controls.Add(this.select);
            this.Font = new System.Drawing.Font("新細明體", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "episodeForm";
            this.Text = "選擇欄位";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select;
        private System.Windows.Forms.ListBox EpisodeListBox;
        private System.Windows.Forms.Label label1;
    }
}