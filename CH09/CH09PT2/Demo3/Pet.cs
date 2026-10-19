namespace Demo3
{
    // AGGREGATION: a Pet HAS an Owner.
    // The Owner is created outside the Pet and passed into the constructor,
    // so the Owner can exist without the Pet (hollow diamond in the UML).
    // Pet also USES the Species enum.
    public class Pet
    {
        private string _name;
        private Species _species;
        private Owner _owner;   // Pet HAS-A Owner

        public Pet(string name, Species species, Owner owner)
        {
            _name = name;
            _species = species;
            _owner = owner;     // stores a reference to an existing Owner
        }

        public string Name
        {
            get { return _name; }
        }

        public Species Species
        {
            get { return _species; }
        }

        public Owner Owner
        {
            get { return _owner; }
        }
    }
}
