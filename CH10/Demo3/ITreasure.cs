namespace Demo3;

// Relationships:
//   ITreasure IS-A IComparable<ITreasure> (interface inheritance):
//   every treasure must also be comparable, so a List<ITreasure> can be sorted.
//   CommonTreasure and RareTreasure IMPLEMENT ITreasure ("can-do" / realization).
public interface ITreasure : IComparable<ITreasure>
{
    string Name { get; }
    decimal Value { get; }

    // Each class decides how it looks on the form.
    void ShowTreasure(Label label);
}
