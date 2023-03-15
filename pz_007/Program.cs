namespace pz_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store x5RetailGroup = new();

            #region FirstCart

            Bread b1 = new("asd", 1.1f, "g");
            Milk m1 = new("fsdsfd", 2.0f, 0.0f);
            Beer bee1 = new("fsd", 10.0f,50.0f);
            Beer bee2 = new("fsd", 10.0f,50.0f);

            #endregion

            x5RetailGroup.SaveOrder(new Client(), b1,m1,bee1,bee2);


        }
    }
}