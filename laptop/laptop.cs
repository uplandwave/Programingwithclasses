public class laptop {
    private double _screenSize;
    private string _os;
    private bool _touchscreen;

    public laptop(double screensize, string os, bool ts){
        _screenSize = screensize;
        _os = os;
        _touchscreen = ts;
    }

    public void ShowDetails(){
        Console.WriteLine($"{_screenSize} {_os} {_touchscreen}");
    }

}