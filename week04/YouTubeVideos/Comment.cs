using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Comment {
    //comment data
    private string _username;
    private string _text;

    //constructors
    public Comment()
    {
        SetUsername("n/a");
        SetText("n/a");
    }
    public Comment(string username, string text)
    {
        SetUsername(username);
        SetText(text);
    }
    //display
    public void Display()
    {
        Console.WriteLine(GetUsername() + ": ");
        Console.WriteLine(GetText());
    }
    //getter & setters
    public void SetUsername(string newUsername)
    {
        _username = newUsername;
    }
    public string GetUsername()
    {
        return _username;
    }
    public void SetText(string newText)
    {
        _text = newText;
    }
    public string GetText()
    {
        return _text;
    }
}
