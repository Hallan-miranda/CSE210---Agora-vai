using System;


class MathAssigment : Assigment
{
    private string _textbookSection;
    private string _problems;   

    public void SetProblems(string problens)
    {
        _problems = problens;
    }

    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetHomeworkList()
    {
        return ($"{_textbookSection} {_problems}");
    }
}