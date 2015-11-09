/*
 * Created by: Alex Mathias
 * Created on: 09-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 4-06
 * This program compares two strings and tells if they are the same
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringComparison
{
    public partial class frmStringComparison : Form
    {
        public bool StringComparing(string first, string second)
        {
            bool response = false;

            string Upper;
            string secondUpper;

            Upper = first.ToUpper();
            secondUpper = second.ToUpper();

            if (Upper.Length == secondUpper.Length)
            {
                if(Upper == secondUpper)
                {
                    response = true;
                }
            }
            else
            {
                response = false;
            }
                


            return response;
        }
        public frmStringComparison()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            // Variables and Input

            string Upper = txtFirstString.Text;
            string Lower = txtSecondString.Text;
            bool response;

            //Process

            response = StringComparing(Upper, Lower);

            if (response == true)
            {
                this.lblCompare.Text = ("They are the same.");
            }
            else if (response == false)
            {
                this.lblCompare.Text = ("They are not the same");
            }

        }
    }
}
