using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meyvesebzeayirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstMeyve.Items.Clear();
            lsbSebze.Items.Clear();
            for (int i = 0; i < lstTumu.Items.Count; i++)
            {
                if (lstTumu.Items[i].ToString() == "Patates" ||
                    lstTumu.Items[i].ToString() == "Soğan" ||
                    lstTumu.Items[i].ToString() == "Ispanak") 
                {
                    lsbSebze.Items.Add(lstTumu.Items[i]);
                }

                else
                {
                    lstMeyve.Items.Add(lstTumu.Items[i]);
                }
            }    
        }
    }
}
