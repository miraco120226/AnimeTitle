namespace AnimeTitle
{
    partial class FindPage
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.refresh = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select
            // 
            this.select.Font = new System.Drawing.Font("新細明體", 10F);
            this.select.Location = new System.Drawing.Point(620, 15);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(140, 30);
            this.select.TabIndex = 5;
            this.select.Text = "選擇";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(20, 60);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(740, 470);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(20, 15);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 30);
            this.back.TabIndex = 7;
            this.back.Text = "←";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(90, 15);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(50, 30);
            this.next.TabIndex = 8;
            this.next.Text = "→";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 540);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(740, 10);
            this.progressBar1.TabIndex = 9;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(160, 15);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(50, 30);
            this.refresh.TabIndex = 10;
            this.refresh.Text = "重整";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(230, 15);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(50, 30);
            this.stop.TabIndex = 11;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // FindPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.select);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindPage";
            this.Text = "FindPage";
            this.Resize += new System.EventHandler(this.FindPage_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button select;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button stop;
    }
}