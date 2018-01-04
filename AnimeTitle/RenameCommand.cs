using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Form;

namespace AnimeTitle
{
    class RenameCommand
    {
        string sourceFileName;
        string destFileName;
        R_ListCell rc;
        bool done;

        public RenameCommand(string sf, string df,R_ListCell cell)
        {
            sourceFileName = sf;
            destFileName = df;
            rc = cell;
            done = false;
        }

        public bool execute()
        {
            if (done)
            {
                return false;
            }

            try
            {
                File.Move(sourceFileName, destFileName);
                rc.setRightCell(destFileName);
                done = true;
                return true;
            }
            catch
            {
                MessageBox.Show("重新命名失敗");
                return false;
            }
        }

        public bool undo()
        {
            if (!done)
            {
                return false;
            }

            try
            {
                File.Move(destFileName, sourceFileName);
                rc.setRightCell(sourceFileName);
                done = false;
                return true;
            }
            catch
            {
                MessageBox.Show("復原失敗");
                return false;
            }
        }
    }
}
