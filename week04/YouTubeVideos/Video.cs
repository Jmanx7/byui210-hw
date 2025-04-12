using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Video
{
    //video data
    private string _title;
    private string _author;
    private double _length;
    //stores comments
    private List<Comment> _comments = new List<Comment>();

    //constructors
    public Video()
    {
        SetTitle("New Video");
        SetAuthor("n/a");
        SetLength(0.0);
    }
    public Video(string _title, string _author, double _length)
    {
        SetTitle(_title);
        SetAuthor(_author);
        SetLength(_length);
    }
    //display
    public void Display()
    {
        //video information
        Console.WriteLine(GetTitle());
        Console.WriteLine("By " + GetAuthor());
        
        Console.Write(GetLength());
        Console.WriteLine(" Seconds Long");

        //spacing
        Console.WriteLine("");

        Console.WriteLine("Comments:");
        //display comments
        for (int i = 0; i < CommentAmount(); i++)
        {
            GetComment(i).Display();
        }
    }

    //comment functions
    public void AddComment(string username, string text)
    {
        Comment newComment = new Comment(username, text);
        _comments.Add(newComment);
    }
    public Comment GetComment(int commentIndex)
    {
        return _comments[commentIndex];
    }
    public int CommentAmount()
    {
        return _comments.Count();
    }

    //title getter/setters
    public void SetTitle(string _newTitle)
    {
        _title = _newTitle;
    }
    public string GetTitle()
    {
        return _title;
    }
    //author getter/setrters
    public void SetAuthor(string _newAuthor)
    {
        _author = _newAuthor;
    }
    public string GetAuthor()
    {
        return _author;
    }
    //length getter/setters
    public void SetLength(double _newLength)
    {
        _length = _newLength;
    }
    public double GetLength()
    {
        return _length;
    }

}
