namespace Demo2
{
    // Assignment USES the Category enum (its Category property is an enum value).
    // All properties are auto-implemented: the compiler creates the hidden fields.
    public class Assignment
    {
        public string Title { get; set; } = "";
        public DateTime DueDate { get; set; }
        public int Points { get; set; }
        public Category Category { get; set; }

        // Example: "Lab 1 (LAB) - 20 pts - due 10/20/2026"
        public string Display()
        {
            return $"{Title} ({Category}) - {Points} pts - due {DueDate:d}";
        }
    }
}
