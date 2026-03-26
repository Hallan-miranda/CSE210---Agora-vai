    using System;
    using System.Reflection.Metadata;

    class Word
    {
        string _text; 
        public bool _isHidden; 

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            string _textHidden = "";

            for (int i = 0; i < _text.Length; i++)
            {
                _textHidden += "_";    
            }

            _text = _textHidden;
            _isHidden = true;
        }
        public void Show()
        {
            Console.WriteLine(_text);
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            return(_text);
        }
    }