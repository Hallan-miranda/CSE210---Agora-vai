using System;


class Video
{
    string _title;
    string _author;
    int _length;
    List<Comments> _comments = new List<Comments>();


    public Video(string tilte, string author,int length)
    {
        _title = tilte;
        _author = author;
        _length = length;    
    }

    public void SetComments(string name, string text)
    {
        _comments.Add(new Comments(name, text));
    }

    public int GetCommentCount()
    {
        int count = _comments.Count();

        return count;
    }
    public void DisplayComments()
    {
        foreach (Comments comment in _comments)
        {
            string _comment = comment.DisplayComment() + "\n";
            Console.WriteLine(_comment);
        }
    }
    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Author: {_author} | Titel: {_title} | Time: {_length} sec \n");
    }
    



}