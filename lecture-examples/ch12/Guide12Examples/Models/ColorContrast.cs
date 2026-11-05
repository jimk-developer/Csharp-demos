namespace Guide12Examples.Models;

/// <summary>
/// Guide 12, Section 3: Measures how readable text is on a background color.
/// Uses the WCAG (Web Content Accessibility Guidelines) contrast-ratio formula.
/// A ratio of 4.5 : 1 or higher is the usual minimum for normal-size text.
/// </summary>
public static class ColorContrast
{
    public const double MinimumRecommendedRatio = 4.5;

    /// <summary>Returns a ratio from 1.0 (no contrast) to 21.0 (black on white).</summary>
    public static double GetContrastRatio(Color foreground, Color background)
    {
        double lighter = Math.Max(RelativeLuminance(foreground), RelativeLuminance(background));
        double darker = Math.Min(RelativeLuminance(foreground), RelativeLuminance(background));

        return (lighter + 0.05) / (darker + 0.05);
    }

    public static bool IsHighContrast(Color foreground, Color background) =>
        GetContrastRatio(foreground, background) >= MinimumRecommendedRatio;

    /// <summary>How bright a color appears to the human eye, from 0 (black) to 1 (white).</summary>
    private static double RelativeLuminance(Color color)
    {
        return 0.2126 * Linearize(color.R)
             + 0.7152 * Linearize(color.G)
             + 0.0722 * Linearize(color.B);
    }

    private static double Linearize(int channel)
    {
        double value = channel / 255.0;
        return value <= 0.03928 ? value / 12.92 : Math.Pow((value + 0.055) / 1.055, 2.4);
    }
}
