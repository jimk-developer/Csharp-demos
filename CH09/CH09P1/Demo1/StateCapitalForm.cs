namespace Demo1
{
    public partial class StateCapitalForm : Form
    {
        // The program can store up to 20 states
        const int MAX_STATES = 20;
        State[] states = new State[MAX_STATES];
        int stateCount = 0;   // how many spots in the array are filled

        public StateCapitalForm()
        {
            InitializeComponent();

            // Start with 5 states
            states[0] = new State("Missouri", "Jefferson City");
            states[1] = new State("Illinois", "Springfield");
            states[2] = new State("Kansas", "Topeka");
            states[3] = new State("Texas", "Austin");
            states[4] = new State("Ohio", "Columbus");
            stateCount = 5;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string search = txtState.Text.Trim().ToLower();

            // Only loop through the filled spots (not all 20)
            for (int i = 0; i < stateCount; i++)
            {
                // Case-insensitive: compare both in lowercase
                if (states[i].GetName().ToLower() == search)
                {
                    lblResult.Text = "The capital of " + states[i].GetName() +
                                     " is " + states[i].GetCapital() + ".";
                    ShowAddControls(false);
                    return;   // found it - stop here
                }
            }

            // If we get here, the state was not found
            lblResult.Text = "I don't know that state yet. What is its capital?";
            ShowAddControls(true);
            txtCapital.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (stateCount >= MAX_STATES)
            {
                lblResult.Text = "The list is full.";
                ShowAddControls(false);
                return;
            }

            // Create a new State object and put it in the next open spot
            string name = txtState.Text.Trim();
            string capital = txtCapital.Text.Trim();
            states[stateCount] = new State(name, capital);
            stateCount++;

            lblResult.Text = "Thanks! I now know the capital of " + name + ".";
            ShowAddControls(false);
        }

        // Shows or hides the capital text box and Add button
        private void ShowAddControls(bool show)
        {
            txtCapital.Visible = show;
            btnAdd.Visible = show;
            txtCapital.Clear();
        }
    }
}
