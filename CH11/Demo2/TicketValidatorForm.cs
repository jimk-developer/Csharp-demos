using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2
{
    public partial class TicketValidatorForm : Form
    {
        public TicketValidatorForm()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                int row = int.Parse(txtRow.Text);
                int seat = int.Parse(txtSeat.Text);

                // The constructor throws InvalidRowException or InvalidSeatException
                // if a value is out of range.
                Ticket ticket = new Ticket(row, seat);

                lblResult.ForeColor = Color.Black;
                lblResult.Text = "Ticket is valid";
            }
            
            catch (FormatException)
            {
                ShowError("Row and seat must be whole numbers");
            }
            catch (ArgumentException ex)
            {
                // InvalidRowException and InvalidSeatException both inherit from
                // ArgumentException, so this one catch block handles both.
                ShowError(ex.Message);
            }
        }

        private void ShowError(string message)
        {
            lblResult.ForeColor = Color.Red;
            lblResult.Text = message;
        }
    }
}
