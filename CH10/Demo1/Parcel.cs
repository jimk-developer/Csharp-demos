namespace Demo1;

// Relationships:
//   Parcel IS-A System.Object (every C# class inherits from Object).
//   Parcel is the BASE CLASS of InsuredParcel.
//   Parcel HAS-A string and a DateTime (its fields).
public class Parcel
{
    // protected (#) = this class and its subclasses can use these fields.
    protected string _recipient;
    protected DateTime _shipDate;

    public Parcel(string recipient, DateTime shipDate)
    {
        _recipient = recipient;
        _shipDate = shipDate;
    }

    public string Recipient
    {
        get { return _recipient; }
    }

    public DateTime ShipDate
    {
        get { return _shipDate; }
    }

    // virtual = a subclass is allowed to replace (override) this property.
    public virtual decimal Price
    {
        get { return 4.00m; }
    }

    // override = replaces Object.ToString().
    // Price is virtual, so an InsuredParcel prints its own $6.50 here.
    public override string ToString()
    {
        return $"{_shipDate:d}, {_recipient}, {Price:C}";
    }
}
