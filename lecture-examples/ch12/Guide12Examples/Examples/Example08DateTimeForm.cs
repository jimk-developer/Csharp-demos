using Guide12Examples.Models;

namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 8: Date/Time Controls
// ---------------------------------------------------------------------
// Lecture flow:
//  1. MonthCalendar  = full calendar grid, always visible.
//     DateTimePicker = compact field; shows a month calendar only when
//                      the user clicks its down arrow.
//  2. DateChanged is the MonthCalendar's DEFAULT EVENT.
//  3. SelectionStart / SelectionEnd hold the selected date range.
//  4. DateTime methods:
//       ToShortDateString()  3/14/2026
//       ToLongDateString()   Saturday, March 14, 2026
//       AddDays(), AddMonths(), AddYears()  return a NEW date
//  5. MaxDate = the last day the user can select.
//  6. The Reservation class (Models folder) uses the same methods.
// =====================================================================
public partial class Example08DateTimeForm : Form
{
    public Example08DateTimeForm()
    {
        InitializeComponent();

        // Dates that depend on "today" are set in code, not in the designer.
        reservationCalendar.MinDate = DateTime.Today;
        reservationCalendar.MaxDate = DateTime.Today.AddMonths(6);   // last selectable day

        ShowSelection();
    }

    // DEFAULT EVENT for a MonthCalendar
    private void reservationCalendar_DateChanged(object sender, DateRangeEventArgs e)
    {
        ShowSelection();
    }

    // DEFAULT EVENT for a DateTimePicker
    private void dueDatePicker_ValueChanged(object sender, EventArgs e)
    {
        DateTime dueDate = dueDatePicker.Value.Date;
        int daysAway = (dueDate - DateTime.Today).Days;

        pickerResultLabel.Text =
            $"dueDatePicker.Value = {dueDate.ToShortDateString()}\r\n" +
            $"That is {daysAway} day(s) from today.";
    }

    private void ShowSelection()
    {
        // The example from Guide 12
        DateTime chosenDate = reservationCalendar.SelectionStart;
        DateTime checkoutDate = chosenDate.AddDays(3);

        Reservation reservation = Reservation.FromSelection(
            reservationCalendar.SelectionStart, reservationCalendar.SelectionEnd);

        outputTextBox.Text =
            $"SelectionStart.ToShortDateString() : {chosenDate.ToShortDateString()}\r\n" +
            $"SelectionStart.ToLongDateString()  : {chosenDate.ToLongDateString()}\r\n" +
            $"SelectionEnd.ToShortDateString()   : {reservationCalendar.SelectionEnd.ToShortDateString()}\r\n" +
            "\r\n" +
            $"chosenDate.AddDays(3)    : {checkoutDate.ToShortDateString()}\r\n" +
            $"chosenDate.AddMonths(1)  : {chosenDate.AddMonths(1).ToShortDateString()}\r\n" +
            $"chosenDate.AddYears(1)   : {chosenDate.AddYears(1).ToShortDateString()}\r\n" +
            "\r\n" +
            $"Reservation : {reservation}\r\n" +
            $"MaxDate     : {reservationCalendar.MaxDate.ToLongDateString()}";
    }
}
