// Demo1. Number Rotator
// Rotates three whole numbers one position to the left each time the button is clicked.
// Concepts: ref parameters, void method, swapping values with a temporary variable.

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Demo 1: RotateLeft()
        // Shifts three integers one position to the left; the first value moves to the end.
        // Accepts three integers by reference and has no return value.
        //   first  - in: the first number,  out: the second number
        //   second - in: the second number, out: the third number
        //   third  - in: the third number,  out: the original first number
        private void RotateLeft(ref int first, ref int second, ref int third)
        {
            // Save the first value before it gets overwritten.
            int temp = first;

            first = second;
            second = third;
            third = temp;
        }

        // The calling method: gathers and validates input, calls RotateLeft(),
        // then displays the changed values.
        private void btnRotate_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            // Validate all three boxes before doing anything.
            if (int.TryParse(txtNum1.Text, out num1) &&
                int.TryParse(txtNum2.Text, out num2) &&
                int.TryParse(txtNum3.Text, out num3))
            {
                // ref must appear in the call as well as in the parameter list.
                // Because these are passed by reference, RotateLeft() changes
                // num1, num2 and num3 right here in this method.
                RotateLeft(ref num1, ref num2, ref num3);

                // Write the rotated values back into the same boxes.
                txtNum1.Text = num1.ToString();
                txtNum2.Text = num2.ToString();
                txtNum3.Text = num3.ToString();

                lblStatus.Text = "Rotated left.";
            }
            else
            {
                lblStatus.Text = "Please enter three whole numbers";
            }
        }
    }
}
