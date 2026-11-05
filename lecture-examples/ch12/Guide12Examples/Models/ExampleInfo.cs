namespace Guide12Examples.Models;

/// <summary>
/// Describes one example in the launcher: which Guide 12 section it supports,
/// the concepts it shows, and how to create its Form.
/// </summary>
public sealed class ExampleInfo
{
    public ExampleInfo(int number, string title, string concepts, Func<Form> createForm)
    {
        Number = number;
        Title = title;
        Concepts = concepts;
        CreateForm = createForm;
    }

    /// <summary>Matches the section number in Guide 12.</summary>
    public int Number { get; }

    public string Title { get; }

    public string Concepts { get; }

    public Func<Form> CreateForm { get; }

    public override string ToString() => $"Example {Number:00}: {Title}";
}
