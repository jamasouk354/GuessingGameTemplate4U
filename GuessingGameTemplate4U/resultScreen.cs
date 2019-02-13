using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class resultScreen : UserControl
    {
        public resultScreen()
        {
            InitializeComponent();
        }

        private void resultScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.numList.Count; i++)
            {
                guessTakenLabel.Text += Form1.numList.Count;
                origOrder.Text += Form1.numList[i] + " ";                             
            }
            for (int i = 0; i < Form1.numList.Count; i++)
            {
                Form1.numList.Sort();
                sortOrder.Text += Form1.numList[i] + " ";
            }            
        }
    }
}
