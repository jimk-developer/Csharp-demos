namespace Demo1;

// Relationships:
//   MainForm IS-A Form (inheritance).
//   MainForm OWNS its List<Parcel> (composition): the form creates it, and it lives only as long as the form.
//   The list HAS Parcel objects (aggregation); each item may really be an InsuredParcel (polymorphism).
//   MainForm USES Parcel and InsuredParcel (dependency): it creates them and calls their members.
public partial class MainForm : Form
{
    private const int MaxParcels = 10;

    private readonly List<Parcel> _parcels = new List<Parcel>();

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnShip_Click(object? sender, EventArgs e)
    {
        string recipient = txtRecipient.Text.Trim();
        string insuranceCode = txtInsuranceCode.Text.Trim();

        if (recipient == "")
        {
            MessageBox.Show("Please enter a recipient.", "Missing Recipient");
            return;
        }

        if (_parcels.Count >= MaxParcels)
        {
            MessageBox.Show($"You can only ship {MaxParcels} parcels.", "Limit Reached");
            return;
        }

        // A base-class variable can hold either object type.
        Parcel parcel;
        if (insuranceCode == "")
        {
            parcel = new Parcel(recipient, dtpShipDate.Value.Date);
        }
        else
        {
            parcel = new InsuredParcel(recipient, dtpShipDate.Value.Date, insuranceCode);
        }

        _parcels.Add(parcel);

        // Items.Add calls parcel.ToString() for us; the object decides which version runs.
        lstLog.Items.Add(parcel);

        // Polymorphism: p.Price runs Parcel.Price or InsuredParcel.Price depending on the real object.
        decimal total = 0;
        foreach (Parcel p in _parcels)
        {
            total += p.Price;
        }
        lblTotal.Text = $"Total: {total:C}";

        txtRecipient.Clear();
        txtInsuranceCode.Clear();
        txtRecipient.Focus();
    }
}
