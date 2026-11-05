namespace Guide12Examples.Models;

/// <summary>
/// Guide 12, Section 3: Approximates how a color looks to a person with
/// red-green color blindness (deuteranopia). This is a classroom
/// approximation, not a medical tool.
/// </summary>
/// <remarks>
/// Purple is a mix of blue and red. When red is hard to perceive, purple
/// looks like blue, which is why blue and purple are also hard to tell apart.
/// </remarks>
public static class ColorBlindnessSimulator
{
    // Simulation matrix for deuteranopia (Machado, Oliveira and Fernandes, 2009).
    private static readonly double[,] DeuteranopiaMatrix =
    {
        {  0.367322, 0.860646, -0.227968 },
        {  0.280085, 0.672501,  0.047413 },
        { -0.011820, 0.042940,  0.968881 }
    };

    public static Color SimulateRedGreen(Color original)
    {
        double r = original.R;
        double g = original.G;
        double b = original.B;

        int newRed = Clamp(DeuteranopiaMatrix[0, 0] * r + DeuteranopiaMatrix[0, 1] * g + DeuteranopiaMatrix[0, 2] * b);
        int newGreen = Clamp(DeuteranopiaMatrix[1, 0] * r + DeuteranopiaMatrix[1, 1] * g + DeuteranopiaMatrix[1, 2] * b);
        int newBlue = Clamp(DeuteranopiaMatrix[2, 0] * r + DeuteranopiaMatrix[2, 1] * g + DeuteranopiaMatrix[2, 2] * b);

        return Color.FromArgb(original.A, newRed, newGreen, newBlue);
    }

    private static int Clamp(double value) => (int)Math.Round(Math.Clamp(value, 0, 255));
}
