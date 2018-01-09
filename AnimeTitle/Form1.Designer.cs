namespace AnimeTitle
{
    partial class AnimeTitle
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
            this.searchButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.epi_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.addAll = new System.Windows.Forms.Button();
            this.addfile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.animeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rename = new System.Windows.Forms.Button();
            this.undoRename = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.DownBtnPanel = new System.Windows.Forms.Panel();
            this.cleanRight = new System.Windows.Forms.Button();
            this.cleanLeft = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.UpBtnPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.DownBtnPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.UpBtnPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(0, 60);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(190, 25);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.epi_col,
            this.title_col});
            this.listView1.Location = new System.Drawing.Point(10, 100);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(190, 272);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // epi_col
            // 
            this.epi_col.Text = "集數";
            this.epi_col.Width = 50;
            // 
            // title_col
            // 
            this.title_col.Text = "標題";
            this.title_col.Width = 150;
            // 
            // searchName
            // 
            this.searchName.Font = new System.Drawing.Font("新細明體", 10F);
            this.searchName.Location = new System.Drawing.Point(0, 25);
            this.searchName.Margin = new System.Windows.Forms.Padding(0);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(190, 23);
            this.searchName.TabIndex = 2;
            this.searchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "動畫名稱";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchName);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 95);
            this.panel1.TabIndex = 4;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BackColor = System.Drawing.Color.White;
            this.listPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPanel.Location = new System.Drawing.Point(5, 42);
            this.listPanel.Margin = new System.Windows.Forms.Padding(0);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(495, 330);
            this.listPanel.TabIndex = 8;
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add.Location = new System.Drawing.Point(10, 385);
            this.add.Margin = new System.Windows.Forms.Padding(0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(85, 25);
            this.add.TabIndex = 9;
            this.add.Text = "加入";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // addAll
            // 
            this.addAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAll.Location = new System.Drawing.Point(115, 385);
            this.addAll.Margin = new System.Windows.Forms.Padding(0);
            this.addAll.Name = "addAll";
            this.addAll.Size = new System.Drawing.Size(85, 25);
            this.addAll.TabIndex = 10;
            this.addAll.Text = "全部加入";
            this.addAll.UseVisualStyleBackColor = true;
            this.addAll.Click += new System.EventHandler(this.addAll_Click);
            // 
            // addfile
            // 
            this.addfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addfile.Location = new System.Drawing.Point(420, 0);
            this.addfile.Margin = new System.Windows.Forms.Padding(0);
            this.addfile.Name = "addfile";
            this.addfile.Size = new System.Drawing.Size(75, 25);
            this.addfile.TabIndex = 11;
            this.addfile.Text = "加入檔案";
            this.addfile.UseVisualStyleBackColor = true;
            this.addfile.Click += new System.EventHandler(this.addfile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // animeName
            // 
            this.animeName.Font = new System.Drawing.Font("新細明體", 10F);
            this.animeName.Location = new System.Drawing.Point(35, 0);
            this.animeName.Margin = new System.Windows.Forms.Padding(0);
            this.animeName.Name = "animeName";
            this.animeName.Size = new System.Drawing.Size(180, 23);
            this.animeName.TabIndex = 12;
            this.animeName.TextChanged += new System.EventHandler(this.animeName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "標題";
            // 
            // rename
            // 
            this.rename.Location = new System.Drawing.Point(240, 0);
            this.rename.Margin = new System.Windows.Forms.Padding(0);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(75, 25);
            this.rename.TabIndex = 14;
            this.rename.Text = "改名";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // undoRename
            // 
            this.undoRename.Location = new System.Drawing.Point(325, 0);
            this.undoRename.Margin = new System.Windows.Forms.Padding(0);
            this.undoRename.Name = "undoRename";
            this.undoRename.Size = new System.Drawing.Size(75, 25);
            this.undoRename.TabIndex = 15;
            this.undoRename.Text = "復原改名";
            this.undoRename.UseVisualStyleBackColor = true;
            this.undoRename.Click += new System.EventHandler(this.undoRename_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(130, 0);
            this.upButton.Margin = new System.Windows.Forms.Padding(0);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 25);
            this.upButton.TabIndex = 16;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.AllowDrop = true;
            this.downButton.Location = new System.Drawing.Point(262, 0);
            this.downButton.Margin = new System.Windows.Forms.Padding(0);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 25);
            this.downButton.TabIndex = 17;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // DownBtnPanel
            // 
            this.DownBtnPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DownBtnPanel.Controls.Add(this.cleanRight);
            this.DownBtnPanel.Controls.Add(this.downButton);
            this.DownBtnPanel.Controls.Add(this.cleanLeft);
            this.DownBtnPanel.Controls.Add(this.upButton);
            this.DownBtnPanel.Location = new System.Drawing.Point(5, 385);
            this.DownBtnPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DownBtnPanel.MinimumSize = new System.Drawing.Size(475, 25);
            this.DownBtnPanel.Name = "DownBtnPanel";
            this.DownBtnPanel.Size = new System.Drawing.Size(475, 25);
            this.DownBtnPanel.TabIndex = 18;
            // 
            // cleanRight
            // 
            this.cleanRight.AllowDrop = true;
            this.cleanRight.Location = new System.Drawing.Point(358, 0);
            this.cleanRight.Margin = new System.Windows.Forms.Padding(0);
            this.cleanRight.Name = "cleanRight";
            this.cleanRight.Size = new System.Drawing.Size(75, 25);
            this.cleanRight.TabIndex = 17;
            this.cleanRight.Text = "清除";
            this.cleanRight.UseVisualStyleBackColor = true;
            this.cleanRight.Click += new System.EventHandler(this.cleanRight_Click);
            // 
            // cleanLeft
            // 
            this.cleanLeft.Location = new System.Drawing.Point(32, 0);
            this.cleanLeft.Margin = new System.Windows.Forms.Padding(0);
            this.cleanLeft.Name = "cleanLeft";
            this.cleanLeft.Size = new System.Drawing.Size(75, 25);
            this.cleanLeft.TabIndex = 16;
            this.cleanLeft.Text = "清除";
            this.cleanLeft.UseVisualStyleBackColor = true;
            this.cleanLeft.Click += new System.EventHandler(this.cleanLeft_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.panel1);
            this.LeftPanel.Controls.Add(this.listView1);
            this.LeftPanel.Controls.Add(this.addAll);
            this.LeftPanel.Controls.Add(this.add);
            this.LeftPanel.Location = new System.Drawing.Point(10, 10);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPanel.MinimumSize = new System.Drawing.Size(210, 420);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(210, 420);
            this.LeftPanel.TabIndex = 19;
            // 
            // UpBtnPanel
            // 
            this.UpBtnPanel.Controls.Add(this.label2);
            this.UpBtnPanel.Controls.Add(this.animeName);
            this.UpBtnPanel.Controls.Add(this.addfile);
            this.UpBtnPanel.Controls.Add(this.rename);
            this.UpBtnPanel.Controls.Add(this.undoRename);
            this.UpBtnPanel.Location = new System.Drawing.Point(5, 5);
            this.UpBtnPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UpBtnPanel.MinimumSize = new System.Drawing.Size(495, 25);
            this.UpBtnPanel.Name = "UpBtnPanel";
            this.UpBtnPanel.Size = new System.Drawing.Size(495, 25);
            this.UpBtnPanel.TabIndex = 20;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.UpBtnPanel);
            this.RightPanel.Controls.Add(this.listPanel);
            this.RightPanel.Controls.Add(this.DownBtnPanel);
            this.RightPanel.Location = new System.Drawing.Point(220, 10);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RightPanel.MinimumSize = new System.Drawing.Size(510, 420);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(510, 420);
            this.RightPanel.TabIndex = 20;
            // 
            // AnimeTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 436);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(755, 475);
            this.Name = "AnimeTitle";
            this.Text = "AnimeTitle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.AnimeTitle_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DownBtnPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.UpBtnPanel.ResumeLayout(false);
            this.UpBtnPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader epi_col;
        private System.Windows.Forms.ColumnHeader title_col;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button addAll;
        private System.Windows.Forms.Button addfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox animeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.Button undoRename;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Panel DownBtnPanel;
        private System.Windows.Forms.Button cleanRight;
        private System.Windows.Forms.Button cleanLeft;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel UpBtnPanel;
        private System.Windows.Forms.Panel RightPanel;
    }
}

