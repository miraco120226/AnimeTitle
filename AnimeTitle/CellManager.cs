using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace AnimeTitle
{
    public class CellManager
    {
        ControlCollection leftNameControl;
        ControlCollection leftControl;
        ControlCollection midControl;
        ControlCollection rightControl;
        public String title;

        internal Stack<RenameCommand> rnc = new Stack<RenameCommand>();
        internal Stack<int> rncn = new Stack<int>();
        public ListControl lco;

        public CellManager(ListControl owner, ControlCollection lnc, ControlCollection lc, ControlCollection mc, ControlCollection rc)
        {
            lco = owner;
            leftNameControl = lnc;
            leftControl = lc;
            midControl = mc;
            rightControl = rc;
        }

        public int getMaxDigit()
        {
            N_ListCell last_cell = leftNameControl[leftNameControl.Count - 1] as N_ListCell;
            int num = (int)last_cell.getNum();
            int digit = Math.Max(num.ToString().Length,2);
            return digit;
        }

        public string handleNumPad(string input)
        {
            double num = double.Parse(input);
            string result="";
            int digit = ((int)num).ToString().Length;

            for (int i= digit; i < getMaxDigit(); i ++)
            {
                result += "0";
            }

            return result + num.ToString();
        }
        
        public void handleMiddleCell()
        {
            int max = Math.Max(leftControl.Count,rightControl.Count);

            for (int i = midControl.Count; i < max; i++)
            {
                MiddleCell mc = new MiddleCell(lco);
                midControl.Add(mc);
            }

            for (int i = max; i < midControl.Count; i++)
            {
                midControl.RemoveAt(0);
            }
        }

        public ListCell getFocusCell()
        {
            List<ListCell> total = new List<ListCell>();
            total.AddRange(leftNameControl.Cast<ListCell>());
            total.AddRange(leftControl.Cast<ListCell>());
            total.AddRange(rightControl.Cast<ListCell>());
            foreach (ListCell lc in total)
            {
                if (lc.focus)
                {
                    return lc;
                }
            }
            return null;
        }

        public void cleanAllFocus()
        {
            ListCell lc = getFocusCell();
            if (lc!=null){
                lc.cleanFocus();
                lc.canaelRename();
                lc.Refresh();
            }
        }

        public List<ListCell> findNeighborCell(MiddleCell mc)
        {
            int index = midControl.IndexOf(mc);

            List<ListCell> result = new List<ListCell>();

            result.Add(leftNameControl.Cast<ListCell>().ToList().ElementAtOrDefault(index));
            result.Add(leftControl.Cast<ListCell>().ToList().ElementAtOrDefault(index));
            result.Add(rightControl.Cast<ListCell>().ToList().ElementAtOrDefault(index));

            return result;
        }

        public bool checkLeftNumRename(N_ListCell ncl, string text)
        {
            double num = 0;
            int index = leftNameControl.IndexOf(ncl);

            if (!double.TryParse(text,out num))
            {
                return false;
            }

            if (index !=0 && (leftNameControl[index - 1] as N_ListCell).getNum() > num)
            {
                return false;
            }

            return true;
        }

        public void handleLeftNumCell(N_ListCell ncl)
        {
            for (int i = leftNameControl.IndexOf(ncl) + 1; i< leftNameControl.Count; i++)
            {
                N_ListCell pncl = leftNameControl[i - 1] as N_ListCell;
                N_ListCell nncl = leftNameControl[i] as N_ListCell;
                nncl.setNum(Math.Floor(pncl.getNum()) + 1);
            }
            lco.Refresh();
        }

        public void addLeftCell(String str)
        {
            L_ListCell lc = new L_ListCell(str, lco);
            leftControl.Add(lc);

            double previous_num = 0;
            if (leftNameControl.Count != 0)
            {
                previous_num = ((N_ListCell)leftNameControl[leftNameControl.Count - 1]).getNum();
            }

            N_ListCell nc = new N_ListCell(Math.Floor(previous_num) + 1, lco);
            leftNameControl.Add(nc);
            
            handleMiddleCell();
        }

        public void addRightCell(String str)
        {
            R_ListCell lc = new R_ListCell(str, lco);
            rightControl.Add(lc);
            handleMiddleCell();
        }

        public void deleteCell(L_ListCell lc)
        {
            leftNameControl.RemoveAt(leftNameControl.Count-1);
            leftControl.Remove(lc);
            handleMiddleCell();
        }

        public void deleteCell(R_ListCell rc)
        {
            rightControl.Remove(rc);
            handleMiddleCell();
        }

        public void moveCell(L_ListCell lc, int index)
        {
            List<L_ListCell> list = leftControl.Cast<L_ListCell>().ToList<L_ListCell>();
            list.Remove(lc);

            if (index < 0)
            {
                index = 0;
            }

            if (index < list.Count)
            {
                list.Insert(index, lc);
            }
            else
            {
                list.Add(lc);
            }
            
            leftControl.Clear();
            leftControl.AddRange(list.ToArray());
            lco.Refresh();
        }

        public void moveCell(R_ListCell rc, int index)
        {            
            List<R_ListCell> list = rightControl.Cast<R_ListCell>().ToList<R_ListCell>();
            list.Remove(rc);

            if(index < 0)
            {
                index = 0;
            }

            if (index < list.Count)
            {
                list.Insert(index, rc);
            }
            else
            {
                list.Add(rc);
            }

            rightControl.Clear();
            rightControl.AddRange(list.ToArray());
            lco.Refresh();
        }

        public int getCellIndex(L_ListCell lc)
        {
            return leftControl.IndexOf(lc);
        }

        public int getCellIndex(R_ListCell rc)
        {
            return rightControl.IndexOf(rc);
        }

        public List<string> getFinalStringList()
        {
            List<string> fs = new List<string>();

            int count = Math.Min(leftControl.Count, rightControl.Count);

            for(int i = 0; i < count; i++)
            {
                string leftnum = (leftNameControl[i] as N_ListCell).getText();
                leftnum = handleNumPad(leftnum);

                string left = (leftControl[i] as L_ListCell).getText();
                string extend = (rightControl[i] as R_ListCell).getExtendFileName();

                string final = title + "-" + leftnum + "-" + left + extend;
                fs.Add(final);
            }

            return fs;
        }

        public bool renameRight()
        {
            List<string> fs = getFinalStringList();
            R_ListCell rc;

            for (int i = 0; i < fs.Count; i++)
            {
                rc = rightControl[i] as R_ListCell;
                if (!rc.renameFile(fs[i]))
                {
                    for (int j = 0; j < i; j++)
                    {
                        rnc.Pop().undo();
                    }
                   
                    MessageBox.Show("請修正第"+(i+1)+"個選項");
                    break;
                }
            }

            rncn.Push(fs.Count);            
            return true;
        }

    }
}
