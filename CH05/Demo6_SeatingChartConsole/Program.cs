// ---------------------------------------------------------------------------
// Demo 6 - Seating Chart (console)
// Chapter 5 demo: nested definite loops and exact output formatting
//
// Concepts on display:
//   - two validation loops, one per prompt - the "indefinite loop" pattern
//     from Demo 1, here keeping a value inside a legal range
//   - nested for loops: the OUTER loop walks the rows, the INNER loop walks
//     the seats, and the inner counter restarts on every outer pass
//   - interpolated strings with a width specifier, {seat,CellWidth}, and
//     the "00" numeric format, which is what keeps the columns straight
//   - char arithmetic to turn a row number into a row letter
//
// The table is laid out like the multiplication table from Lab 6: a header
// row, a dashed separator, and a "|" after every cell.
//
// Part of the Demo6 project. Open Demo6.slnx in Visual Studio and start it
// with Ctrl+F5 so the console window stays open at the end.
// ---------------------------------------------------------------------------

using System;

namespace Demo6;

internal class Program
{
    private const int MinRows = 1;
    private const int MaxRows = 26;   // one letter per row, A through Z
    private const int MinSeats = 1;
    private const int MaxSeats = 30;

    private const int LabelWidth = 5; // the row-letter column
    private const int CellWidth = 4;  // one seat cell, not counting the "|"

    private static void Main()
    {
        // ---- Ask for the number of rows -------------------------------------
        // An indefinite loop again: keep asking until the answer is usable.
        int rows = 0;
        bool haveRows = false;

        while (!haveRows)
        {
            Console.WriteLine("How many rows should the chart have?");
            string rowInput = Console.ReadLine() ?? "";

            if (!int.TryParse(rowInput, out rows) || rows < MinRows || rows > MaxRows)
            {
                Console.WriteLine("Invalid number of rows");
            }
            else
            {
                haveRows = true;
            }
        }

        // ---- Ask for the number of seats ------------------------------------
        // The same loop a second time. Writing it once and calling it twice
        // needs methods, which come later in the course.
        int seats = 0;
        bool haveSeats = false;

        while (!haveSeats)
        {
            Console.WriteLine("How many seats per row should the chart have?");
            string seatInput = Console.ReadLine() ?? "";

            if (!int.TryParse(seatInput, out seats) || seats < MinSeats || seats > MaxSeats)
            {
                Console.WriteLine("Invalid number of seats");
            }
            else
            {
                haveSeats = true;
            }
        }

        // ---- Header row -----------------------------------------------------
        // The corner cell is blank; then one right-aligned seat number per
        // column, each followed by a "|".
        Console.Write(new string(' ', LabelWidth) + "|");

        for (int seat = 1; seat <= seats; seat++)
        {
            // {seat,CellWidth} means "right-align in a field CellWidth
            // characters wide". The width must be a constant.
            Console.Write($"{seat,CellWidth}|");
        }

        Console.WriteLine();

        // ---- Separator ------------------------------------------------------
        // Each seat column takes CellWidth + 1 characters, plus the label
        // column and its "|".
        int lineWidth = LabelWidth + 1 + (seats * (CellWidth + 1));
        Console.WriteLine(new string('-', lineWidth));

        // ---- The chart itself: one nested loop -------------------------------
        for (int row = 1; row <= rows; row++)
        {
            // Row 1 -> 'A', row 2 -> 'B', and so on. 'A' + 0 is 'A'.
            char rowLetter = (char)('A' + row - 1);

            Console.Write($"{rowLetter,LabelWidth}|");

            // The inner counter starts over at 1 for every row. If "seat"
            // were declared outside this loop it would keep the value it
            // ended on and only the first row would print.
            for (int seat = 1; seat <= seats; seat++)
            {
                // "00" pads a single-digit seat number to two digits: A01.
                string label = $"{rowLetter}{seat:00}";
                Console.Write($"{label,CellWidth}|");
            }

            Console.WriteLine();
        }

        // ---- Summary --------------------------------------------------------
        Console.WriteLine();
        Console.WriteLine($"Total seats: {rows * seats}");
    }
}
