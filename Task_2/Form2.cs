using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form2 : Form
    {
        //public string Text {  get; set; }
        
        public Form2(string someText)
        {
            InitializeComponent();
            reductTextBox.Text = someText;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;
            if (form1 != null )
            {
                form1.TextBoxText = reductTextBox.Text; 
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
