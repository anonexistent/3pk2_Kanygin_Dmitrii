﻿namespace pz_005
{
    internal class City : Maps, ICloneable
    {
        public Country Coy { get; set; }
        public double Volume { get; set; }
        public City(int id,string name,Country c, double volume) : base(id, name)
        {
            Coy = c; Volume = volume; 
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
