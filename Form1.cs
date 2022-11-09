using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harmon_ashley_assignment14
{
    public partial class DiceGame : Form
    {
        public int dob = 0;
        public int tri = 0;
        public int score = 0;
        public int totalscore = 0;
        public int rollcount = 0;

        public DiceGame()
        {
            InitializeComponent();
        }

    
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int x;
            score = 0;
            x = rd.Next(1, 7);
            this.textBoxDie1.Text = x.ToString();
            score += x;
            x = rd.Next(1, 7);
            this.textBoxDie2.Text = x.ToString();
            score += x;
            x = rd.Next(1, 7);
            this.textBoxDie3.Text = x.ToString();
            score += x;
            // count doubles and triples
            if (this.textBoxDie1.Text == this.textBoxDie2.Text && this.textBoxDie1.Text == this.textBoxDie3.Text)
            {
                score = score + 50;
                tri++;
                this.textBoxTriples.Text = tri.ToString();
                this.Bonus.Text = "Tripples Bonus $50.00";
            }
            else if (this.textBoxDie1.Text == this.textBoxDie2.Text ||
                this.textBoxDie1.Text == this.textBoxDie3.Text ||
                this.textBoxDie3.Text == this.textBoxDie2.Text)
            {
                score = score + 25;
                dob++;
                this.textBoxDoubles.Text = dob.ToString();
                this.Bonus.Text = "Doubles Bonus $25.00";
            }
            else
                this.Bonus.Text = "No Bonus";
            // populate score and total score text boxes
            this.textBoxScore.Text = score.ToString();
            totalscore = totalscore + score;
            this.textBoxTotalScore.Text = totalscore.ToString();
            rollcount++;
            this.textBoxNumRolls.Text = rollcount.ToString();
        }

        private void DiceGame_Load(object sender, EventArgs e)
        {

        }
    }
}
