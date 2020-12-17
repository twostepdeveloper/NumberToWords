using System;
using System.Collections.Generic;
using System.Text;

namespace NumToWord.Strategy
{
    interface IWordStrategy
    {
        string GetWord(string number);
    }
}
