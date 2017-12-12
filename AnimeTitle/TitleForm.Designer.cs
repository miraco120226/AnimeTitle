namespace AnimeTitle
{
    partial class TitleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TitleListBox = new System.Windows.Forms.ListBox();
            this.select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "title找不到，請選擇title之欄位";
            // 
            // TitleListBox
            // 
            this.TitleListBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.TitleListBox.FormattingEnabled = true;
            this.TitleListBox.ItemHeight = 20;
            this.TitleListBox.Location = new System.Drawing.Point(25, 50);
            this.TitleListBox.Name = "TitleListBox";
            this.TitleListBox.Size = new System.Drawing.Size(220, 204);
            this.TitleListBox.TabIndex = 5;
            // 
            // select
            // 
            this.select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.select.Font = new System.Drawing.Font("新細明體", 10F);
            this.select.Location = new System.Drawing.Point(65, 273);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(140, 30);
            this.select.TabIndex = 4;
            this.select.Text = "選擇";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleListBox);
            this.Controls.Add(this.select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TitleForm";
            this.Text = "選擇欄位";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TitleListBox;
        private System.Windows.Forms.Button select;
    }
}