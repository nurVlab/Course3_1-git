using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course3_1
{
    internal class UI_tips
    {

        public void updateTree(TreeNode tree, Dictionary<string, string> data, bool RAM, string symbol) {
            int i = 0;
            foreach (var par in data) {
                // tree.Nodes[i].Remove();
                if (RAM)
                {
                    int val = (int)(float.Parse(par.Value) * 1024);
                    tree.Nodes[i].Text = par.Key + ": " + val + symbol;
                }
                else {
                    tree.Nodes[i].Text = par.Key + ": " + par.Value + symbol;
                }
                i++;
            }
            
        }
    }
}
