namespace AnimeTitle
{
    partial class TableForm
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
            this.TableListBox = new System.Windows.Forms.ListBox();
            this.select = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // TableListBox
            // 
            this.TableListBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.TableListBox.FormattingEnabled = true;
            this.TableListBox.ItemHeight = 20;
            this.TableListBox.Location = new System.Drawing.Point(25, 25);
            this.TableListBox.Name = "TableListBox";
            this.TableListBox.Size = new System.Drawing.Size(140, 264);
            this.TableListBox.TabIndex = 5;
            this.TableListBox.SelectedValueChanged += new System.EventHandler(this.TitleListBox_SelectedValueChanged);
            // 
            // select
            // 
            this.select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.select.Font = new System.Drawing.Font("新細明體", 10F);
            this.select.Location = new System.Drawing.Point(25, 300);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(140, 30);
            this.select.TabIndex = 4;
            this.select.Text = "選擇";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(190, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(600, 300);
            this.webBrowser1.TabIndex = 6;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 361);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.TableListBox);
            this.Controls.Add(this.select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableForm";
            this.Text = "選擇表格";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox TableListBox;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}