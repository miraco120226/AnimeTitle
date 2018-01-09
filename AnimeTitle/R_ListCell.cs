using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AnimeTitle
{
    public partial class R_ListCell : global::AnimeTitle.ListCell
    {
        public static int width = 200;
        public static int height = 20;
        Label TextLabel;
        TextBox editName;
        string fullPath;
        string path;
        RenameCommand rc;

        public R_ListCell()
        {
            InitializeComponent();
        }

        public R_ListCell(string input, ListControl owner)
        {
            TextLabel = GetTextLabel();
            editName = GetEditLabel();

            MinimumSize = new Size(width, height);
            setSize(width, height);

            fullPath = input;

            try
            {
                text = getText(fullPath);
                path = getPath(fullPath);
            }
            catch
            {
                MessageBox.Show("檔案輸入錯誤");
                text = "null";
            }

            lco = owner;
            cm = owner.cm;
            TextLabel.Text = text;
            TextLabel.DoubleClick += TextLabel_DoubleClick;
        }

        public static string getPath(string fullPath)
        {
            string text = fullPath.Substring(fullPath.LastIndexOf(@"\") + 1);
            return fullPath.Remove(fullPath.LastIndexOf(@"\") + 1, text.Length);
        }

        public static string getText(string fullPath)
        {
            return fullPath.Substring(fullPath.LastIndexOf(@"\") + 1);
        }

        public void setRightCell(string fullpath)
        {
            string path = getPath(fullpath);
            string name = getText(fullpath);

            fullPath = path + name;
            text = name;
            TextLabel.Text = name;
        }

        public bool renameFile(string newName)
        {
            if (!(File.Exists(fullPath)))
            {
                MessageBox.Show("檔案不存在");
                return false;
            }
            else
            {
                rc = new RenameCommand(fullPath, path + newName,this);
                if (rc.execute())
                {
                    lco.cm.rnc.Push(rc);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void TextLabel_DoubleClick(object sender, EventArgs e)
        {
            Environment.GetFolderPath(Environment.SpecialFolder.System);
            ProcessStartInfo pInfo = new ProcessStartInfo();
            pInfo.FileName = fullPath;
            pInfo.UseShellExecute = true;
            try
            {
                Process p = Process.Start(pInfo);
            }
            catch
            {
                MessageBox.Show("開啟錯誤");
            }
        }

        protected override void handleRename()
        {
            if (renameFile(editName.Text))
            {
                lco.cm.rncn.Push(1);
            }
        }

        public string getExtendFileName()
        {
            return text.Substring(text.LastIndexOf("."));
        }

    }
}
