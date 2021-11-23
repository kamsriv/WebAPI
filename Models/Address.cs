
namespace StudentAPI
{
    class Address : IAddress
    {
        public string Plot_Floor { get; set; }
        public string Street { get; set; }
        public ICountry Country { get; set; }
        public IState State { get; set; }
        public string PIN { get; set; }
    }
}