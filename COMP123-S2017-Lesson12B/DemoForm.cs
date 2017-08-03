using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Otaviano Pires Amancio
 * StudentID: 300910504
 * Date: August 2, 2017
 * Description: Demo Application to showcase windows forms andUI Controls
 * Version: 0.1 - Project was created
 */

namespace COMP123_S2017_Lesson12B
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the HelloButton event handler for the click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloButton_Click(object sender, EventArgs e)
        {
            if(NameTextbox.Text.Length > 0)
            {
                HelloLabel.Text = "Hello, " + NameTextbox.Text + "!";
            }
            else
            {
                HelloLabel.Text = "Hello, World!";
            }
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
