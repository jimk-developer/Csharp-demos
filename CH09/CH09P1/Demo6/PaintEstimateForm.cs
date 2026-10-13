namespace Demo6
{
    public partial class PaintEstimateForm : Form
    {
        const int MAX_WALLS = 20;
        Wall[] walls = new Wall[MAX_WALLS];
        int wallCount = 0;

        public PaintEstimateForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (wallCount >= MAX_WALLS)
            {
                lblMessage.Text = "Maximum of 20 walls";
                return;
            }

            string name = txtName.Text.Trim();
            int width = int.Parse(txtWidth.Text);
            int height = int.Parse(txtHeight.Text);

            // 1. Create a new Wall object (the constructor does the math)
            Wall wall = new Wall(name, width, height);

            // 2. Add it to the array
            walls[wallCount] = wall;
            wallCount++;

            // 3. Show it in the output
            lstOutput.Items.Add(wall.Display());

            // 4. Clear the boxes and go back to the name box
            txtName.Clear();
            txtWidth.Clear();
            txtHeight.Clear();
            txtName.Focus();
        }
    }
}
