namespace pz_005
{

    {
        public Country Coy { get; set; }
        public double Volume { get; set; }
        public City(int id, string name, Country c, double volume) : base(id, name)
        {

        }

        public override string ToString()
        {
            return $"{Id}. {Name}({Coy.Name}) — ";
        }

        public object Clone()
        {
            //return MemberwiseClone();
            return new City(Id, Name, new Country(Coy.Id, Coy.Name, Coy.Volume), Volume);
        }



    }
}