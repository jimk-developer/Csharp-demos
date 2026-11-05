namespace Guide12Examples.Models;

/// <summary>
/// Guide 12, Section 8: A simple reservation built from the dates a user
/// picks on a MonthCalendar. Shows the DateTime methods from the guide:
/// AddDays(), ToShortDateString(), and ToLongDateString().
/// </summary>
public class Reservation
{
    public const int DefaultNights = 3;

    public Reservation(DateTime checkInDate, int nights)
    {
        if (nights < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(nights), "A stay must be at least one night.");
        }

        CheckInDate = checkInDate.Date;
        Nights = nights;
    }

    public DateTime CheckInDate { get; }

    public int Nights { get; }

    /// <summary>AddDays() returns a NEW date; it does not change CheckInDate.</summary>
    public DateTime CheckOutDate => CheckInDate.AddDays(Nights);

    /// <summary>
    /// Builds a reservation from a MonthCalendar selection. One selected day
    /// uses the default stay; a range of days becomes one night per day.
    /// </summary>
    public static Reservation FromSelection(DateTime selectionStart, DateTime selectionEnd)
    {
        int daysSelected = (selectionEnd.Date - selectionStart.Date).Days + 1;
        int nights = daysSelected == 1 ? DefaultNights : daysSelected;

        return new Reservation(selectionStart, nights);
    }

    public override string ToString() =>
        $"{Nights} night(s): {CheckInDate.ToShortDateString()} to {CheckOutDate.ToShortDateString()}";
}
