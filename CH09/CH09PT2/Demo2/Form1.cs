namespace Demo2
{
    // Form1 HAS an array of Assignment objects (up to 10).
    public partial class Form1 : Form
    {
        private const int MAX_ASSIGNMENTS = 10;

        private Assignment[] _assignments = new Assignment[MAX_ASSIGNMENTS];
        private int _count = 0;          // how many array slots are filled
        private int _totalPoints = 0;

        public Form1()
        {
            InitializeComponent();

            // Fill the ComboBox from the Category enum
            cboCategory.DataSource = Enum.GetValues<Category>();

            UpdateLabels();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();

            // 1. Validate input
            if (title == "")
            {
                MessageBox.Show("Title is required.");
                txtTitle.Focus();
                return;
            }

            if (!int.TryParse(txtPoints.Text, out int points) || points <= 0)
            {
                MessageBox.Show("Points must be a whole number greater than 0.");
                txtPoints.Focus();
                return;
            }

            // 2. Stop when the array is full
            if (_count == MAX_ASSIGNMENTS)
            {
                MessageBox.Show("List is full");
                return;
            }

            // 3. Create the object (object initializer syntax) and store it
            Assignment assignment = new Assignment
            {
                Title = title,
                DueDate = dtpDueDate.Value.Date,
                Points = points,
                Category = (Category)cboCategory.SelectedItem!
            };

            _assignments[_count] = assignment;
            _count++;
            _totalPoints += points;

            // 4. Show it and update the labels
            lstOutput.Items.Add(assignment.Display());
            UpdateLabels();

            // 5. Reset for the next entry
            txtTitle.Clear();
            txtPoints.Clear();
            txtTitle.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            bool found = false;

            // Only loop through the filled slots
            for (int i = 0; i < _count; i++)
            {
                if (_assignments[i].DueDate.Date <= dtpDueBy.Value.Date)
                {
                    lstOutput.Items.Add(_assignments[i].Display());
                    found = true;
                }
            }

            if (!found)
            {
                lstOutput.Items.Add("No assignments found");
            }
        }

        private void UpdateLabels()
        {
            lblCount.Text = $"Assignments: {_count}/{MAX_ASSIGNMENTS}";
            lblTotalPoints.Text = $"Total Points: {_totalPoints}";
        }
    }
}
