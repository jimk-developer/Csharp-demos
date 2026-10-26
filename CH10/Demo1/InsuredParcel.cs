namespace Demo1;

// Relationships:
//   InsuredParcel IS-A Parcel (inheritance): it inherits _recipient, _shipDate,
//   Recipient and ShipDate, and adds an insurance code.
public class InsuredParcel : Parcel
{
    protected string _insuranceCode;

    // : base(...) sends the shared values up to the Parcel constructor.
    public InsuredParcel(string recipient, DateTime shipDate, string insuranceCode)
        : base(recipient, shipDate)
    {
        _insuranceCode = insuranceCode;
    }

    public string InsuranceCode
    {
        get { return _insuranceCode; }
    }

    // override: reuse the base price, then add the insurance fee.
    public override decimal Price
    {
        get { return base.Price + 2.50m; }
    }

    // override: reuse the base text, then add the insurance code.
    public override string ToString()
    {
        return base.ToString() + $", Insured: {_insuranceCode}";
    }
}
