// Demo4. Test Score Report
// Accepts up to 10 test scores and reports how many passed, how many failed,
// and the percent passing.
// Concepts: out parameters, params array, class-level array and counter,
//           counting with if statements, percent calculation, enabling/disabling controls.

namespace Demo4
{
    public partial class Form1 : Form
    {
        private const int MAX_SCORES = 10;      // most scores the user can enter
        private const int PASSING_SCORE = 70;   // 70 or higher passes
        private const int MIN_SCORE = 0;
        private const int MAX_SCORE = 100;

        // Class-level: these keep their values between button clicks.
        private int[] scores = new int[MAX_SCORES];   // the scores entered so far
        private int scoreCount = 0;                   // how many scores are in the array

        public Form1()
        {
            InitializeComponent();
        }

        // Demo 4: AnalyzeScores()
        // Counts passing and failing scores and finds the percent passing.
        // Has no return value and uses output parameters for the results.
        //   passing        - out: how many scores are 70 or higher
        //   failing        - out: how many scores are below 70
        //   percentPassing - out: percent of scores that passed (0 - 100)
        //   testScores     - params: the scores to analyze. The caller can pass an
        //                    array, or a list of values such as
        //                    AnalyzeScores(out p, out f, out pct, 85, 62, 90);
        private void AnalyzeScores(out int passing, out int failing, out double percentPassing, params int[] testScores)
        {
            // Every out parameter must be assigned before the method ends.
            passing = 0;
            failing = 0;
            percentPassing = 0.0;

            foreach (int score in testScores)
            {
                if (score >= PASSING_SCORE)
                {
                    passing++;
                }
                else
                {
                    failing++;
                }
            }

            // Avoid dividing by zero if no scores were passed in.
            if (testScores.Length > 0)
            {
                percentPassing = (double)passing / testScores.Length * 100;
            }
        }

        // The calling method: validates the score, stores it, calls AnalyzeScores(),
        // then displays the three values the method sent back through out parameters.
        private void btnAddScore_Click(object sender, EventArgs e)
        {
            int score;

            // Validate: must be a whole number from 0 to 100.
            if (!int.TryParse(txtScore.Text, out score) || score < MIN_SCORE || score > MAX_SCORE)
            {
                lblError.Text = "Enter a whole number from 0 to 100";
                txtScore.SelectAll();
                txtScore.Focus();
                return;
            }

            lblError.Text = "";

            // Store the score and count it.
            scores[scoreCount] = score;
            scoreCount++;

            // Pass only the scores entered so far, not all 10 slots.
            // Unused slots hold 0, which would count as failing scores.
            int[] enteredScores = new int[scoreCount];
            Array.Copy(scores, enteredScores, scoreCount);

            // The caller's variables do not need values first -- the method fills them in.
            int passing, failing;
            double percentPassing;
            AnalyzeScores(out passing, out failing, out percentPassing, enteredScores);

            lblCount.Text = "Scores Entered: " + scoreCount + "/" + MAX_SCORES;
            lblPassing.Text = "Passing: " + passing;
            lblFailing.Text = "Failing: " + failing;
            lblPercent.Text = "Percent Passing: " + percentPassing.ToString("F1") + "%";

            txtScore.Clear();
            txtScore.Focus();

            // The array is full -- no more scores can be added.
            if (scoreCount == MAX_SCORES)
            {
                btnAddScore.Enabled = false;
                txtScore.Enabled = false;
            }
        }
    }
}
