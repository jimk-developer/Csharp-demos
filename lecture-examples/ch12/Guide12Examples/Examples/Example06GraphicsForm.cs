using Guide12Examples.Models;

namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 6: Graphics
// ---------------------------------------------------------------------
// Lecture flow:
//  1. A PictureBox displays graphics from a bitmap, icon, JPEG, GIF,
//     or other image file type.
//  2. FIRST STEP to show a JPEG: drag a PictureBox from the Toolbox
//     onto the Form (not the JPEG, and there is no "Image" control).
//  3. Designer route (no code): Image property shows (none) ->
//     click (none) -> click the ellipsis (...) -> Select Resource dialog
//     -> Import -> OK.  Demonstrate live on designerPictureBox.
//  4. Code route (this file): load the file and assign the Image property.
//  5. SizeMode controls how the picture fits; you do not have to drag the
//     PictureBox borders to fit the image.
// =====================================================================
public partial class Example06GraphicsForm : Form
{
    public Example06GraphicsForm()
    {
        InitializeComponent();
    }

    // Load is a Form's default event (double-click an empty area of the
    // form in the designer to generate this method).
    private void Example06GraphicsForm_Load(object sender, EventArgs e)
    {
        // The sample image is copied next to the .exe by the project file.
        string samplePath = Path.Combine(AppContext.BaseDirectory, "Images", "sample-photo.jpg");

        if (File.Exists(samplePath))
        {
            LoadImage(samplePath);
        }
    }

    private void loadImageButton_Click(object sender, EventArgs e)
    {
        if (openImageDialog.ShowDialog(this) == DialogResult.OK)
        {
            LoadImage(openImageDialog.FileName);
        }
    }

    // One handler shared by all four SizeMode radio buttons.
    // Each radio button's Tag holds the name of a PictureBoxSizeMode value.
    private void SizeModeRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton radioButton = (RadioButton)sender;

        if (radioButton.Checked)
        {
            photoPictureBox.SizeMode = Enum.Parse<PictureBoxSizeMode>((string)radioButton.Tag!);
        }
    }

    private void LoadImage(string filePath)
    {
        try
        {
            // Image.FromFile keeps the file locked, so we copy it into a new
            // Bitmap and release the file right away.
            Image newImage;
            string description;

            using (Image fileImage = Image.FromFile(filePath))
            {
                description = ImageDescriber.Describe(fileImage, filePath);
                newImage = new Bitmap(fileImage);
            }

            Image? oldImage = photoPictureBox.Image;
            photoPictureBox.Image = newImage;   // <-- the Image property
            oldImage?.Dispose();

            imageInfoLabel.Text = description;
        }
        catch (Exception ex) when (ex is OutOfMemoryException or FileNotFoundException or ArgumentException)
        {
            // GDI+ reports "not a valid image" as OutOfMemoryException.
            MessageBox.Show($"That file could not be opened as an image.\n\n{ex.Message}", "Load image");
        }
    }
}
