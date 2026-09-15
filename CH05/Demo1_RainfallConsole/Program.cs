// ---------------------------------------------------------------------------
// Demo 1 - Rainfall Log (console)
// Chapter 5 demo: indefinite loop, sentinel value, range check, accumulators
//
// Concepts on display:
//   - indefinite (sentinel-controlled) loop
//   - input validation with double.TryParse
//   - a range check written as a compound condition
//   - four kinds of accumulator: counter, running total, running max, and a
//     conditional counter
//   - guarding a division so an empty run cannot divide by zero
//
// Part of the Demo1 project. Open Demo1.slnx in Visual Studio and start it
// with Ctrl+F5 so the console window stays open at the end.
// ---------------------------------------------------------------------------

using System;

namespace Demo1;

internal class Program
{
    // Named constants instead of "magic numbers" scattered through the code.
    private const double Sentinel = -1.0;
    private const double MinReading = 0.0;
    private const double MaxReading = 20.0;

    private static void Main()
    {
        // ---- Declaration and initialization of the accumulators -------------
        // These MUST be declared before the loop. If they were declared inside
        // the loop they would be re-initialized on every iteration and every
        // total would come out as the last reading entered.
        int readingCount = 0;      // counter accumulator
        double totalRainfall = 0;  // sum accumulator
        double wettestReading = 0; // running maximum
        int dryDayCount = 0;       // conditional counter

        // ---- The indefinite loop -------------------------------------------
        // We do not know how many times this will run, so the loop is
        // controlled by a flag that the sentinel value sets.
        bool finished = false;

        while (!finished)
        {
            Console.Write("Please enter a rainfall reading: ");
            string input = Console.ReadLine() ?? "";

            double reading;

            if (!double.TryParse(input, out reading))
            {
                // Not a number at all.
                Console.WriteLine("Invalid reading");
            }
            else if (reading == Sentinel)
            {
                // The sentinel is NOT data: do not count it, do not add it,
                // and do not complain about it being outside the valid range.
                finished = true;
            }
            else if (reading < MinReading || reading > MaxReading)
            {
                // Range check. Note this test runs only after we know the
                // value is not the sentinel - order matters here.
                Console.WriteLine("Invalid reading");
            }
            else
            {
                // Valid reading: update every accumulator.
                readingCount++;
                totalRainfall += reading;

                // Running maximum. On the first reading there is nothing to
                // compare against yet, so seed it with that reading.
                if (readingCount == 1 || reading > wettestReading)
                {
                    wettestReading = reading;
                }

                if (reading == MinReading)
                {
                    dryDayCount++;
                }
            }
        }

        // ---- Report ---------------------------------------------------------
        Console.WriteLine();

        if (readingCount == 0)
        {
            // The guard: with no readings there is no average to compute.
            Console.WriteLine("No readings entered");
        }
        else
        {
            double average = totalRainfall / readingCount;

            Console.WriteLine($"Number of readings: {readingCount}");
            Console.WriteLine($"Total rainfall: {totalRainfall:F2}");
            Console.WriteLine($"Average reading: {average:F2}");
            Console.WriteLine($"Wettest reading: {wettestReading:F2}");
            Console.WriteLine($"Dry days: {dryDayCount}");
        }
    }
}
