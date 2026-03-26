using System;
using System.Linq;

class Scripture
{
    public Reference _reference;
    public List<Word> _words = new List<Word>();

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<Word> _noHiddenWord = _words.Where(word => !word.IsHidden()).ToList();

        for(int i = 0; i < numberToHide && _noHiddenWord.Count > 0; i++)
        {
            int index = random.Next(_noHiddenWord.Count);
            _noHiddenWord[index].Hide();

            _noHiddenWord.RemoveAt(index);
        }

    }

    public string GetDisplayText()
    {
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");    
        }

        Console.WriteLine("\n Press enter to continue or type 'quite' to finsh:");

        return("");
    }
    public bool IsCompletelyHidden()
    {
        int _false = 0;
        int _true = 0;
        bool _hidden = false;

        for (int i = 0; i < _words.Count; i++)
        {
            
            {
                if (_words[i]._isHidden == true)
                {
                    _true +=1;
                }
                else
                {
                    _false += 1;
                }
            }

            if (_false == 0)
            {
                _hidden = true;
            }
            else
            {
                _hidden = false;
            }
        }

        return _hidden;
    } 

    public void AddText(string text)
    {
        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
}