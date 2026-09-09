namespace Demo3
{
    public partial class DiceBandsForm : Form
    {
        private Random randGenerator = new Random();
        private int playerScore = 0;
        private int computerScore = 0;
        private int roundsPlayed = 0;

        public DiceBandsForm()
        {
            InitializeComponent();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            int roll = randGenerator.Next(1, 7);
            lblRoll.Text = "Computer rolled a " + roll;

            if (roll <= 2)
            {
                playerScore++;
            }
            else
            {
                computerScore++;
            }

            roundsPlayed++;
            lblPlayerScore.Text = "Player Score: " + playerScore;
            lblComputerScore.Text = "Computer Score: " + computerScore;

            if (roundsPlayed == 3)
            {
                if (playerScore > computerScore)
                {
                    lblWinner.Text = "Player Wins!!!";
                }
                else
                {
                    lblWinner.Text = "Computer Wins!!!";
                }
                btnLow.Enabled = false;
                btnMiddle.Enabled = false;
                btnHigh.Enabled = false;
            }
        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            int roll = randGenerator.Next(1, 7);
            lblRoll.Text = "Computer rolled a " + roll;

            if (roll == 3 || roll == 4)
            {
                playerScore++;
            }
            else
            {
                computerScore++;
            }

            roundsPlayed++;
            lblPlayerScore.Text = "Player Score: " + playerScore;
            lblComputerScore.Text = "Computer Score: " + computerScore;

            if (roundsPlayed == 3)
            {
                if (playerScore > computerScore)
                {
                    lblWinner.Text = "Player Wins!!!";
                }
                else
                {
                    lblWinner.Text = "Computer Wins!!!";
                }
                btnLow.Enabled = false;
                btnMiddle.Enabled = false;
                btnHigh.Enabled = false;
            }

        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            int roll = randGenerator.Next(1, 7);
            lblRoll.Text = "Computer rolled a " + roll;

            if (roll >= 5)
            {
                playerScore++;
            }
            else
            {
                computerScore++;
            }

            roundsPlayed++;
            lblPlayerScore.Text = "Player Score: " + playerScore;
            lblComputerScore.Text = "Computer Score: " + computerScore;

            if (roundsPlayed == 3)
            {
                if (playerScore > computerScore)
                {
                    lblWinner.Text = "Player Wins!!!";
                }
                else
                {
                    lblWinner.Text = "Computer Wins!!!";
                }
                btnLow.Enabled = false;
                btnMiddle.Enabled = false;
                btnHigh.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnLow.Enabled = true;
            btnMiddle.Enabled = true;
            btnHigh.Enabled = true;

            lblComputerScore.Text = "";
            lblPlayerScore.Text = "";
            lblRoll.Text = "";
            lblWinner.Text = "";

            randGenerator = new Random();
            playerScore = 0;
            computerScore = 0;
            roundsPlayed = 0;

        }
    }
}
