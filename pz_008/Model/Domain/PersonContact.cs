﻿namespace pz_008.Model.Domain
{
    internal class PersonContact : IContact
    {
        public string Name { get; }
        public long Phone {get; }
        public string Region { get; }

        public PersonContact(string name, long phone, string region)
        {
            Name = name;
            Phone = phone;
            Region = region;
        }

        public string[] GetInfo()
        {
            return new string[3] { Name, Phone.ToString(), Region };
        }
    }
}
