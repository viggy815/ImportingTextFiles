/*Student Scores- Text Files
 * David Vignero
 * POS/409
 * John Becton
 * March 13, 2017
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Vignero_Text_Files
{
    public partial class StudentScores : Form

    {
        //declaring objects and variables
        ArrayList scoreList = new ArrayList();
        ArrayList score = new ArrayList();
        double average;
        double sum;
    
        int counter;
        public StudentScores()
        {
            InitializeComponent();
            //creating text file when the applicaiton is loaded and adding values
            StreamWriter writer = new StreamWriter("StudentScores.txt", false);
            writer.WriteLine("David Jones, 78");
            writer.WriteLine("Josh Smith, 73");
            writer.WriteLine("Mike Wells, 68");
            writer.WriteLine("Kevin Brokovich, 91");
            writer.WriteLine("Stephen Brooks, 71");
            writer.WriteLine("Marshall Stewart, 90");
            writer.WriteLine("John Parks, 63");
            writer.WriteLine("Jackie Walker, 95");
            writer.WriteLine("Nicole Roberts, 79");
            writer.WriteLine("Paul Stout, 57");
            writer.Close();
        }
        //code used to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //code used to clear the fields and put that to their default value
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAverage.ResetText();
            lblHighest.ResetText();
            lblScores.ResetText();

        }
        //code to handle the start button
        private void btnStart_Click(object sender, EventArgs e)
        {
            string line = null;
            string dir = Path.GetFullPath("StudentScores.txt");
            try
            {
                lblScores.ResetText();
                
           
                StreamReader reader = new StreamReader(dir);
                // loops through the lines in the text file
                while ((line = reader.ReadLine()) != null)
                {
                    //adds each line to an arraylist
                    scoreList.Add(line);
                    //splits the values of each line to add the numeric value to its own arraylist
                    string[] pieces = line.Split();
                    score.Add(pieces[2]);
               //loops through the values of the score arraylist
                  for(int x = 0; x < score.Count; x++)
                    {
                        //code to sort the arraylist in order to get the highet score
                        score.Sort();
                        score.Reverse();
                        if (score[0] == pieces[2])
                        {
                            //outputs the highest score and the student that achieved the highest score
                            lblHighest.Text = string.Format(pieces[0] + " " + pieces[1] + " " + pieces[2] + "%\n");
                        }


                    }
                   


                }
             
              //loops through arraylist and ouputs all the scores and student names
                for(int x = 0; x <= scoreList.Count -1; x++)
                {
                    lblScores.Text += scoreList[x].ToString()+"%\n\n";
               
                }
                //closing reader object
                reader.Close();
               //calling method
                getAverage();
            }
            catch (Exception j)
            {
                MessageBox.Show(j.ToString());
            }
        }
        //method used to get the average score
        public void getAverage()

        {

            counter = 0;
            sum = 0;
            average = 0;
            //loops through until counter is 1 less then the length of the score arraylist
             while (counter < score.Count)
             {
                //constantly calculates the average while it loops through to get the final average when it loops through the final time
                 sum = sum + double.Parse(score[counter].ToString());
              average = sum / score.Count;
                lblAverage.Text = average.ToString()+"%";
                counter++;
            }
          //clearing both arraylist to avoid duplicate data when the applicaiton is cleared and started, or if the start button it selected before clearing
            score.Clear();
            scoreList.Clear();
        }
    }
}
