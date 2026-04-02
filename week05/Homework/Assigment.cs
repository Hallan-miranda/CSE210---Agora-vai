using System;


class Assigment
{
    private string _studentName;
    private string _topic;

    public void SetTopic( string topic)
    {
            _topic = topic;
    }   

    public void SetstudentName(string studentName)
    {
            _studentName = studentName;
    }   

    public string GetSumary()
    {
        return($"{_studentName} - {_topic}");       
    }
}