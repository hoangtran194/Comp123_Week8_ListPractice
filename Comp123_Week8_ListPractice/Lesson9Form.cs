using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_Week8_ListPractice
{
    public partial class Lesson9Form : Form
    {
        /// <summary>
        /// This is the constructor method
        /// </summary>
        public Lesson9Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the shared event handler for all of calculator button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorNumbers_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button; //Down casting

            //ResultLabel.Text = selectedButton.Text;

            /*
            switch (selectedButton.Text)
            {
                case "1":
                    break;
                default:
                    break;
            }
            */

            try
            {
                int.Parse(selectedButton.Text);
                ResultLabel.Text = selectedButton.Text;
            }
            catch 
            {
                ResultLabel.Text = "Not a Number";
            }
        }
    }
}
