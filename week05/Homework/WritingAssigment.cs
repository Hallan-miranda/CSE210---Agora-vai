using System;


class WritingAssigment : Assigment
{
    private string _title;

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return (_title);
    }
}