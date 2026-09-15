// ---------------------------------------------------------------------------
// Demo 3 - Campus Kiosk Donations (console)
// Chapter 5 demo: parallel accumulators selected by a switch, case-insensitive
// input, two-stage validation, sentinel-controlled loop
//
// Concepts on display:
//   - one indefinite loop driving two prompts
//   - switch structure used to pick which accumulator to update
//   - case-insensitive comparison done once, at the point of input
//   - parallel accumulators (a total AND a count for each kiosk)
//   - finding the largest of three values with if / else if
//
// Part of the Demo3 project. Open Demo3.slnx in Visual Studio and start it
// with Ctrl+F5 so the console window stays open at the end.
// ---------------------------------------------------------------------------

using System;

namespace Demo3;

internal class Program
{
    private const double MinDonation = 0.01;
    private const double MaxDonation = 500.00;

    private static void Main()
    {
        // Parallel accumulators: three totals and three counts.
        // This is deliberately clumsy - it is the argument for arrays, which
        // is the next chapter.
        double atriumTotal = 0, bookstoreTotal = 0, commonsTotal = 0;
        int atriumCount = 0, bookstoreCount = 0, commonsCount = 0;

        bool finished = false;

        while (!finished)
        {
            // ---- Stage 1: which kiosk? -------------------------------------
            Console.WriteLine("Which kiosk? (a, b, c, or q to quit)");
            string rawLetter = Console.ReadLine() ?? "";

            // Normalize once: trim the whitespace and fold the case here, so
            // nothing below has to worry about "A" vs "a".
            string letter = rawLetter.Trim().ToLower();

            if (letter == "q")
            {
                finished = true;
            }
            else if (letter != "a" && letter != "b" && letter != "c")
            {
                // Note the && - the value must fail ALL three tests to be bad.
                Console.WriteLine("Invalid kiosk");
                Console.WriteLine();
            }
            else
            {
                // ---- Stage 2: how much? ------------------------------------
                Console.WriteLine("How much was the donation?");
                string rawAmount = Console.ReadLine() ?? "";

                double amount;

                if (!double.TryParse(rawAmount, out amount) ||
                    amount < MinDonation || amount > MaxDonation)
                {
                    // Short-circuit evaluation: when TryParse fails, the two
                    // range tests are never evaluated - which matters here,
                    // because "amount" would be 0 and meaningless.
                    Console.WriteLine("Invalid donation");
                }
                else
                {
                    // Valid: the switch decides WHICH pair of accumulators
                    // to update. The work inside each case is identical in
                    // shape - another hint that an array belongs here.
                    switch (letter)
                    {
                        case "a":
                            atriumTotal += amount;
                            atriumCount++;
                            break;

                        case "b":
                            bookstoreTotal += amount;
                            bookstoreCount++;
                            break;

                        case "c":
                            commonsTotal += amount;
                            commonsCount++;
                            break;

                        default:
                            // Unreachable given the validation above, but a
                            // default case is cheap insurance.
                            Console.WriteLine("Invalid kiosk");
                            break;
                    }
                }

                Console.WriteLine();
            }
        }

        // ---- Report ---------------------------------------------------------
        double grandTotal = atriumTotal + bookstoreTotal + commonsTotal;
        int grandCount = atriumCount + bookstoreCount + commonsCount;

        Console.WriteLine();
        Console.WriteLine($"Atrium Donations: {atriumTotal:C} ({atriumCount})");
        Console.WriteLine($"Bookstore Donations: {bookstoreTotal:C} ({bookstoreCount})");
        Console.WriteLine($"Commons Donations: {commonsTotal:C} ({commonsCount})");
        Console.WriteLine();
        Console.WriteLine($"Grand Total: {grandTotal:C}");

        // ---- Largest of three ----------------------------------------------
        // Ties: this version reports the first kiosk that reaches the high
        // mark. Deciding a tie rule is part of the exercise - ask the class
        // what SHOULD happen when two kiosks match.
        if (grandCount == 0)
        {
            Console.WriteLine("No donations were recorded");
        }
        else if (atriumTotal >= bookstoreTotal && atriumTotal >= commonsTotal)
        {
            Console.WriteLine("Atrium has the most donations");
        }
        else if (bookstoreTotal >= commonsTotal)
        {
            Console.WriteLine("Bookstore has the most donations");
        }
        else
        {
            Console.WriteLine("Commons has the most donations");
        }
    }
}
