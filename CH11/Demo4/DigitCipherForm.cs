using System;
using System.Windows.Forms;

namespace Demo4
{
    public partial class DigitCipherForm : Form
    {
        private DigitCipher _cipher = new DigitCipher();

        public DigitCipherForm()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            ClearErrors();

            try
            {
                // int.Parse throws FormatException; the Key setter throws ArgumentOutOfRangeException.
                _cipher.Key = int.Parse(txtKey.Text);

                // Encode throws InvalidCharacterException for anything that is not a digit.
                txtCode.Text = _cipher.Encode(txtMessage.Text);
            }
            catch (FormatException)
            {
                lblKeyError.Text = "Invalid key";
            }
            catch (ArgumentOutOfRangeException)
            {
                lblKeyError.Text = "Invalid key";
            }
            catch (InvalidCharacterException ex)
            {
                lblMessageError.Text = ex.Message;
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            ClearErrors();

            try
            {
                _cipher.Key = int.Parse(txtKey.Text);
                txtMessage.Text = _cipher.Decode(txtCode.Text);
            }
            catch (FormatException)
            {
                lblKeyError.Text = "Invalid key";
            }
            catch (ArgumentOutOfRangeException)
            {
                lblKeyError.Text = "Invalid key";
            }
            catch (InvalidCharacterException ex)
            {
                lblCodeError.Text = ex.Message;
            }
        }

        private void ClearErrors()
        {
            lblMessageError.Text = "";
            lblCodeError.Text = "";
            lblKeyError.Text = "";
        }
    }
}
