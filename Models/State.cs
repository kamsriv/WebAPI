using System.Collections.Generic;
namespace StudentAPI
{
    public class State : IState
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICountry Country { get; set; }
    }

    public class StateList:Common
    {
        public StateList(string msg, bool success): base(msg, success) {}
        public List<IState> states {get;set;}
    }
}