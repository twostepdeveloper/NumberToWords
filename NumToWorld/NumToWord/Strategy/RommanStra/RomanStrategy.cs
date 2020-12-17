using NumToWord.Strategy.RommanStra;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NumToWord.Common.romman;

namespace NumToWord.Strategy
{
    internal class RomanStrategy : IWordStrategy
    {
        List<RomanModel> romanModel = new List<RomanModel>();

        public RomanStrategy()
        {
            romanModel.Add(new RomanModel()
            {
                Key ="I",
                Value =1,
                Diff =0
            });
            romanModel.Add(new RomanModel()
            {
                Key = "V",
                Value = 5,
                Diff = 0
            });
            romanModel.Add(new RomanModel()
            {
                Key = "X",
                Value = 10,
                Diff = 1
            });
            romanModel.Add(new RomanModel()
            {
                Key = "L",
                Value = 50,
                Diff = 10
            });
            romanModel.Add(new RomanModel()
            {
                Key = "C",
                Value = 100,
                Diff = 10
            });
            romanModel.Add(new RomanModel()
            {
                Key = "D",
                Value = 500,
                Diff = 100
            });

            romanModel.Add(new RomanModel()
            {
                Key = "M",
                Value = 1000,
                Diff = 100
            });
        }

        public string GetWord(string number)
        {
            return GetRomman(int.Parse(number));
        }
        

        private Tuple<RomanModel,RomanModel> GetUpAndDown(int number)
        {
            RomanModel up = null;
            RomanModel down = null ;
            if (romanModel.Any(p => p.Value > number))
            {
                up = (from m in romanModel.Where(p => p.Value > number)
                         orderby m.Value
                         select m).First();
            }
            if(romanModel.Any(p=>p.Value < number))
            {
                down = (from m in romanModel.Where(p => p.Value < number)
                        orderby m.Value descending
                        select m).First();
            }
            return new Tuple<RomanModel, RomanModel>(down, up);
        }

        private RomanModel BestSutableNumber(int number,out bool flag)
        {
            flag = false;
            Tuple<RomanModel, RomanModel> minMax = GetUpAndDown(number);
            if (minMax.Item2 == null)
            {
                return minMax.Item1;
            }
            else
            {
                if(( minMax.Item2.Value-number)<= minMax.Item2.Diff)
                {
                    flag = true;
                    return minMax.Item2;
                }
                else
                {
                    return minMax.Item1;
                }
            }
        }
        
        public string GetRomman(int number)
        {
            string word = string.Empty;
            string num = string.Empty;
            while (number > 0)
            {
                num = number.ToString();
                if (num.Length == 1)
                {
                    word += RommanOnes.GetOnes(number);
                    number = 0;
                }

                else if(romanModel.Any(p => p.Value == number))
                {
                    
                    var temp = romanModel.FirstOrDefault(p => p.Value == number);
                    number = 0;
                    word +=  temp.Key;
                }
                else
                {
                    bool flag;
                    var minMax = BestSutableNumber(number,out flag);

                    if (minMax.Value > number)
                    {
                        var pairs= GetUpAndDown(number);
                        word+=  ((minMax.Key == "M" || minMax.Key == "D")?"C":"X")+ minMax.Key;
                        num = num.Substring(1);
                        number = int.Parse(num);
                    }
                    else
                    {
                        var rep = number / minMax.Value;
                        number = number % minMax.Value;

                        while (rep > 0)
                        {
                            word += minMax.Key;
                            rep--;
                        }
                    }
                }
                num = number.ToString();
            }
            return word;
        }
    }
}
