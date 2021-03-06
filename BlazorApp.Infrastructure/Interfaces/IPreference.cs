using BlazorApp.Core;

namespace Infrastructure{

    public interface IPreference
    {
        ISet<Language>? Languages{get;set;}
        ISet<WorkDay>? WorkDays{get;set;}
        ISet<Location>? Locations{get;set;}
        ISet<Keyword>? Keywords{get;set;}
    }
}