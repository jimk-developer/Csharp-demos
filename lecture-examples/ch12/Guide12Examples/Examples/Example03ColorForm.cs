using Guide12Examples.Models;

namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 3: Color
// ---------------------------------------------------------------------
// Lecture flow:
//  1. The Color class adds color to Forms and controls, usually through
//        BackColor  (background)
//        ForeColor  (foreground / text)
//  2. Predefined colors: Color.Yellow, Color.LightGoldenrodYellow, ...
//     (Test: orderNowButton.BackColor = Color.LightGoldenrodYellow;)
//  3. Custom colors: Color.FromArgb(red, green, blue)
//  4. Accessibility:
//       - use HIGH contrast between text and background (see ColorContrast)
//       - never rely on color alone (add text or a symbol)
//       - red-green color blindness: red vs. green AND blue vs. purple
//         are hard to tell apart (see ColorBlindnessSimulator)
//  5. A popular assumption: lots of blue feels calming and mature.
// =====================================================================
public partial class Example03ColorForm : Form
{
    // Remembers each swatch's real color so the simulation can be turned off.
    private readonly Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();
    private bool isSimulating;
    private bool isCalmingTheme;

    public Example03ColorForm()
    {
        InitializeComponent();
        UpdateContrastReport();
    }

    // ----- BackColor and ForeColor ------------------------------------

    private void yellowBackButton_Click(object sender, EventArgs e)
    {
        orderNowButton.BackColor = Color.Yellow;
        ShowCode("orderNowButton.BackColor = Color.Yellow;");
    }

    private void goldenrodBackButton_Click(object sender, EventArgs e)
    {
        orderNowButton.BackColor = Color.LightGoldenrodYellow;
        ShowCode("orderNowButton.BackColor = Color.LightGoldenrodYellow;");
    }

    private void customColorButton_Click(object sender, EventArgs e)
    {
        // A custom color built from red, green, and blue values (0-255 each)
        orderNowButton.BackColor = Color.FromArgb(194, 65, 12);
        ShowCode("orderNowButton.BackColor = Color.FromArgb(194, 65, 12);   // custom burnt orange");
    }

    private void blackForeButton_Click(object sender, EventArgs e)
    {
        orderNowButton.ForeColor = Color.Black;
        ShowCode("orderNowButton.ForeColor = Color.Black;");
    }

    private void whiteForeButton_Click(object sender, EventArgs e)
    {
        orderNowButton.ForeColor = Color.White;
        ShowCode("orderNowButton.ForeColor = Color.White;");
    }

    private void resetColorsButton_Click(object sender, EventArgs e)
    {
        orderNowButton.BackColor = SystemColors.Control;
        orderNowButton.ForeColor = SystemColors.ControlText;
        ShowCode("orderNowButton.BackColor = SystemColors.Control;  ForeColor = SystemColors.ControlText;");
    }

    // ----- Accessibility ----------------------------------------------

    private void simulateButton_Click(object sender, EventArgs e)
    {
        Control[] coloredControls =
        {
            colorOnlyErrorLabel, colorOnlyOkLabel, betterErrorLabel, betterOkLabel,
            redSwatchLabel, greenSwatchLabel, blueSwatchLabel, purpleSwatchLabel
        };

        isSimulating = !isSimulating;

        foreach (Control control in coloredControls)
        {
            if (isSimulating)
            {
                originalColors[control] = control.BackColor;
                control.BackColor = ColorBlindnessSimulator.SimulateRedGreen(control.BackColor);
            }
            else
            {
                control.BackColor = originalColors[control];
            }
        }

        simulateButton.Text = isSimulating
            ? "&Show original colors"
            : "&Simulate red-green color blindness";
    }

    private void calmingBlueButton_Click(object sender, EventArgs e)
    {
        isCalmingTheme = !isCalmingTheme;

        if (isCalmingTheme)
        {
            BackColor = Color.AliceBlue;
            headerLabel.BackColor = Color.SteelBlue;
            headerLabel.ForeColor = Color.White;
            calmingBlueButton.Text = "Remove &calming blue theme";
        }
        else
        {
            BackColor = SystemColors.Control;
            headerLabel.BackColor = Color.FromArgb(30, 27, 46);
            headerLabel.ForeColor = Color.FromArgb(254, 215, 170);
            calmingBlueButton.Text = "Apply &calming blue theme";
        }
    }

    // ----- Helpers ---------------------------------------------------

    private void ShowCode(string code)
    {
        codeLabel.Text = code;
        UpdateContrastReport();
    }

    private void UpdateContrastReport()
    {
        double ratio = ColorContrast.GetContrastRatio(orderNowButton.ForeColor, orderNowButton.BackColor);
        bool isReadable = ratio >= ColorContrast.MinimumRecommendedRatio;

        contrastLabel.Text =
            $"Contrast of orderNowButton text: {ratio:0.00} : 1   " +
            (isReadable ? "PASS (high contrast)" : $"FAIL (aim for {ColorContrast.MinimumRecommendedRatio} : 1 or higher)");

        // Not relying on color alone: the label says PASS/FAIL in words, too.
        contrastLabel.ForeColor = isReadable ? Color.DarkGreen : Color.Firebrick;
    }
}
