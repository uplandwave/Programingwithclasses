public class Job
{
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;


    // Constructor
    public Job(string company, string jobtitle, int startyear, int endyear){
        _company = company;
        _jobTitle = jobtitle;
        _startYear = startyear;
        _endYear = endyear;
    }

    public void Display(){
        Console.WriteLine($"{_company}, {_jobTitle}, {_startYear}, {_endYear}");
    }

}