namespace pz_008.Model.Domain
{
    internal class PersonContact : IContact
    {
        public string Name { get; set; }
        public long Phone {get; set;}
        public string Region { get; set;}

        public string[] GetInfo()
        {
            return new string[3] { Name, Phone.ToString(), Region };
        }
    }
}
