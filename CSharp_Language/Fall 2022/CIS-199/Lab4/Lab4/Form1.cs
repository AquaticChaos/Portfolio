/*
    CIS-199-50-4228 Lab #4
    Due: 10/2/2022
    ID: F2233
    Purpose: Using a GPA and admission test score provided by the user, calculate whether the
        student has been accepted or rejected to this school. Alongside that, keep track of
        how many have been accepted and rejected.
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

namespace Lab4
{
    public partial class Form1 : Form
    {
        int acceptCount = 0, rejectCount = 0; //Tally of accept/reject decisions.
        public Form1()
        {
            InitializeComponent();
        }

        private void admitButton_Click(object sender, EventArgs e)
        {
            float gpaVal; //The value for the Grade Point Average inputted
            int scoreVal; //The value for the admission test score inputted

            //Test score must be between 0 and 100, GPA must be between 0.0 and 4.0!!!
            //Check if above two variables are valid
            if(float.TryParse(gpaTextbox.Text, out gpaVal) && 
                int.TryParse(scoreTextbox.Text, out scoreVal)) //If textbox string invalid
            {
                if((scoreVal < 0 || scoreVal > 100) || 
                    (gpaVal < 0 || gpaVal > 4)) //If values outside of valid range
                {MessageBox.Show("Please enter a GPA between 0 and 4," +
                    " and a test score between 0 and 100");} 
                else if((scoreVal >= 60 && gpaVal >= 3.0) || (scoreVal >= 80 && gpaVal < 3.0))
                {
                    /*If admission is accepted
                        (GPA 3.0 or higher plus Score of at least 60
                        OR GPA lower than 3.0 plus Score of at least 80)*/

                    decisionOutput.Text = "Accept"; //Set output label to say "Accept"
                    acceptCount++; //Increment accept tally by one
                } else
                {
                    /*If admission is rejected
                        (Mostly if Score is below 60 regardless of GPA.)*/

                    decisionOutput.Text = "Reject"; //Set output label to say "Reject"
                    rejectCount++; //Increment reject tally by one
                }
            } else {MessageBox.Show("Please enter a valid gpa and test score");}

            //Update labels for accept and reject tallies, if any changes
            acceptCountLabel.Text = "Accepted:   " + acceptCount;
            rejectCountLabel.Text = "Rejected:   " + rejectCount;
        }
    }
}
