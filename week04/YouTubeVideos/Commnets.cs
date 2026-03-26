using System;
using System.Reflection.Metadata.Ecma335;

class Comments
{
    string _commenterName;
    string _text;

    public Comments(string name, string text)
    {
        _commenterName = name;
        _text = text;
    }

    public string DisplayComment()
    {

        return ($"Name: {_commenterName} \n{_text}");
    }
}