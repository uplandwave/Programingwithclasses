using System;
class Text {
    public string _password;
    public string _site;

    public void Display(string _password, string _site) {
        Console.WriteLine($"Site - {_site}\nPassword - {_password}");
    }
}