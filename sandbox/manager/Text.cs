using System;
public class Text {
    public string _password;
    public string _site;

    public Text(string password, string site)
    {
        _password = password;
        _site = site;
    }

    public void Display() {
        Console.WriteLine($"Site - {_site}\nPassword - {_password}");
    }}