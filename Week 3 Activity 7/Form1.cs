using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3_Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int x; // user input variable

            // confirms the input is a valid integer greater than 0
            if (int.TryParse(inputBox.Text, out x) && x > 0) {

                double pi = 0; // output variable
                int y = 1; // formula variable

                // iterrates through the for loop x number of times using i as a count
                for (int i = 0; i < x; i++)
                {
                    if ((i % 2) == 0) // checks if i is even or odd
                    {
                        pi = pi + ((double) 4 / y); // on even iterations the number is added
                    }
                    else
                    {
                        pi = pi - ((double) 4 / y); // on odd iterations the number is subtracted
                    }
                    y = y + 2; // y is incremented by 2 each time
                }

                label2.Text = "Approximate value of pi after " + inputBox.Text + " terms"; // adds the user input to the ouput text
                outputLabel.Text = "= " + pi.ToString(); // prints the value value of pi
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer"); // if the try parse fails this error message is shown
            }
        }
    }
}
