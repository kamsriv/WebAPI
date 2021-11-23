using System.Collections.Generic;
namespace StudentAPI
{
    class Country : ICountry
    {
        public int ID { get;set; }
        public string Name { get;set;}
    }

    public class CountryList: Common
    {
        public CountryList(string msg, bool success): base(msg,success){
        }
        List<ICountry> Countries{get;set;}
    }
}