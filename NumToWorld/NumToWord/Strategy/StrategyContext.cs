using System;
using System.Collections.Generic;
using System.Text;

namespace NumToWord.Strategy
{
    class StrategyContext: IWordStrategy
    {
        IWordStrategy _strategy;
        public StrategyContext()
        {
            _strategy = new IndiaCurrencyStrategy();
        }

        public string GetWord(string number)
        {
            return _strategy.GetWord(number);
        }
        
        public void SetNewStrategy(IWordStrategy strategy)
        {
            this._strategy = strategy;
        }
    }
}
