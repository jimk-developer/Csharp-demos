namespace Demo3
{
    // Form1 HAS an array of Pet objects; each Pet HAS an Owner object.
    public partial class Form1 : Form
    {
        private Pet[] _pets;

        public Form1()
        {
            InitializeComponent();

            // Create the Owners first...
            Owner maria = new Owner("Maria Lopez", "314-555-0142");
            Owner dev = new Owner("Dev Patel", "314-555-0177");
            Owner sam = new Owner("Sam Carter", "636-555-0119");
            Owner ana = new Owner("Ana Ruiz", "314-555-0163");

            // ...then hand each Owner to a Pet (aggregation)
            _pets = new Pet[]
            {
                new Pet("Biscuit", Species.DOG, maria),
                new Pet("Pickles", Species.CAT, dev),
                new Pet("Kiwi", Species.BIRD, sam),
                new Pet("Bubbles", Species.FISH, ana)
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            foreach (Pet pet in _pets)
            {
                // Case-insensitive match: "kiwi" and "KIWI" both find Kiwi
                if (pet.Name.Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    // Reach through the Pet to its Owner: pet.Owner.Name
                    txtResult.Text = $"{pet.Name}\r\n" +
                                     $"{pet.Species}\r\n" +
                                     "\r\n" +
                                     $"Owner: {pet.Owner.Name}\r\n" +
                                     $"Phone: {pet.Owner.Phone}";
                    return;
                }
            }

            txtResult.Text = "Pet not found";
        }
    }
}
