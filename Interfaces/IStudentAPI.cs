using System.Collections.Generic;

namespace StudentAPI
{
    public interface IStudent
    {        
        long stuID{get;set;}
        string Name{get;set;}
        int Section{get;set;}
        int Class{get;set;}
        IAddress Address{get;set;}
        List<ISubject> Subjects{get;set;}
    }
    public interface IAddress
    {
        string Plot_Floor{get;set;}
        string Street{get;set;}
        ICountry Country{get; set;}
        IState State{get;set;} 
        string PIN{get;set;}
    }

    public interface ICountry
    {
        int ID{get;set;}
        string Name{get;set;}
    }

    public interface IState
    {
        int ID{get;set;}   
        string Name{get;set;}
        ICountry Country{get;set;}
    }

    public interface ISubject
    {
        int ID{get;set;}
        string Name{get;set;}
        int Marks{get;set;}        
        string Term{get;set;}
    }

    public interface IAttendance
    {
        int StartTime{get;set;}
        int EndTime{get;set;}
    }
}