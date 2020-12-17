# NumberToWord
Number2Word in C#

This Project is based for Number to Word Conversion in C#.



    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Random r1 = new Random();
            int i = 100;
            while ((i--) > 0)
            {
                int rNum = r.Next(1, 4999);
                string word = Num2Roman.ToRoman(rNum);
                Console.WriteLine(rNum + "  ====  " + word);
                rNum = r1.Next(int.MinValue, int.MaxValue);
                word = Num2Word.ToWord(rNum, WordNotation.Indian);
                Console.WriteLine(rNum + "  ====  " + word);
                word = Num2Word.ToWord(rNum, WordNotation.Us);
                Console.WriteLine(rNum + "  ====  " + word);
            }
            Console.ReadKey();
        }
    }
    
    
    OutPut Would be Something like this...
    1591  ====  MDXCI
-683332630  ====  Minus Sixty Eight Crore Thirty Three Lakh Thirty Two Thousand Six Hundred Thirty
-683332630  ====  Minus Six Hundred Eighty Three Million Three Hundred Thirty Two Thousand Six Hundred Thirty
1792  ====  MDCCXCII
-1671656159  ====  Minus One Arab Sixty Seven Crore Sixteen Lakh Fifty Six Thousand One Hundred Fifty Nine
-1671656159  ====  Minus One Billion Six Hundred Seventy One Million Six Hundred Fifty Six Thousand One Hundred Fifty Nine
3891  ====  MMMDCCCXCI
-1488688774  ====  Minus One Arab Fourty Eight Crore Eighty Six Lakh Eighty Eight Thousand Seven Hundred Seventy Four
-1488688774  ====  Minus One Billion Four Hundred Eighty Eight Million Six Hundred Eighty Eight Thousand Seven Hundred Seventy Four
4014  ====  MMMMXIV
1849413312  ====  One Arab Eighty Four Crore Ninety Four Lakh Thirteen Thousand Three Hundred Twelve
1849413312  ====  One Billion Eight Hundred Fourty Nine Million Four Hundred Thirteen Thousand Three Hundred Twelve
3465  ====  MMMCDLXV
1740438455  ====  One Arab Seventy Four Crore Four Lakh Thirty Eight Thousand Four Hundred Fifty Five
1740438455  ====  One Billion Seven Hundred Fourty Million Four Hundred Thirty Eight Thousand Four Hundred Fifty Five
3895  ====  MMMDCCCXCV
1307271242  ====  One Arab Thirty Crore Seventy Two Lakh Seventy One Thousand Two Hundred Fourty Two
1307271242  ====  One Billion Three Hundred Seven Million Two Hundred Seventy One Thousand Two Hundred Fourty Two
4305  ====  MMMMCCCV
-623214279  ====  Minus Sixty Two Crore Thirty Two Lakh Fourteen Thousand Two Hundred Seventy Nine
-623214279  ====  Minus Six Hundred Twenty Three Million Two Hundred Fourteen Thousand Two Hundred Seventy Nine
3251  ====  MMMCCLI
-491770082  ====  Minus Fourty Nine Crore Seventeen Lakh Seventy Thousand Eighty Two
-491770082  ====  Minus Four Hundred Ninety One Million Seven Hundred Seventy Thousand Eighty Two
4051  ====  MMMMLI
1961194197  ====  One Arab Ninety Six Crore Eleven Lakh Ninety Four Thousand One Hundred Ninety Seven
1961194197  ====  One Billion Nine Hundred Sixty One Million One Hundred Ninety Four Thousand One Hundred Ninety Seven
2037  ====  MMXXXVII
1106206418  ====  One Arab Ten Crore Sixty Two Lakh Six Thousand Four Hundred Eighteen
1106206418  ====  One Billion One Hundred Six Million Two Hundred Six Thousand Four Hundred Eighteen
3043  ====  MMMXLIII
-700685117  ====  Minus Seventy Crore Six Lakh Eighty Five Thousand One Hundred Seventeen
-700685117  ====  Minus Seven Hundred Million Six Hundred Eighty Five Thousand One Hundred Seventeen
2259  ====  MMCCLIX
-1426163854  ====  Minus One Arab Fourty Two Crore Sixty One Lakh Sixty Three Thousand Eight Hundred Fifty Four
-1426163854  ====  Minus One Billion Four Hundred Twenty Six Million One Hundred Sixty Three Thousand Eight Hundred Fifty Four
1451  ====  MCDLI
1831060228  ====  One Arab Eighty Three Crore Ten Lakh Sixty Thousand Two Hundred Twenty Eight
1831060228  ====  One Billion Eight Hundred Thirty One Million Sixty Thousand Two Hundred Twenty Eight
4085  ====  MMMMLXXXV
18092339  ====  One Crore Eighty Lakh Ninety Two Thousand Three Hundred Thirty Nine
18092339  ====  Eighteen Million Ninety Two Thousand Three Hundred Thirty Nine
1145  ====  MCXLV
160625925  ====  Sixteen Crore Six Lakh Twenty Five Thousand Nine Hundred Twenty Five
160625925  ====  One Hundred Sixty Million Six Hundred Twenty Five Thousand Nine Hundred Twenty Five
788  ====  DCCLXXXVIII
-1996563456  ====  Minus One Arab Ninety Nine Crore Sixty Five Lakh Sixty Three Thousand Four Hundred Fifty Six
-1996563456  ====  Minus One Billion Nine Hundred Ninety Six Million Five Hundred Sixty Three Thousand Four Hundred Fifty Six
4565  ====  MMMMDLXV
1989549923  ====  One Arab Ninety Eight Crore Ninety Five Lakh Fourty Nine Thousand Nine Hundred Twenty Three
1989549923  ====  One Billion Nine Hundred Eighty Nine Million Five Hundred Fourty Nine Thousand Nine Hundred Twenty Three
1190  ====  MCXC
-488690498  ====  Minus Fourty Eight Crore Eighty Six Lakh Ninety Thousand Four Hundred Ninety Eight
-488690498  ====  Minus Four Hundred Eighty Eight Million Six Hundred Ninety Thousand Four Hundred Ninety Eight
2575  ====  MMDLXXV
1535129308  ====  One Arab Fifty Three Crore Fifty One Lakh Twenty Nine Thousand Three Hundred Eight
1535129308  ====  One Billion Five Hundred Thirty Five Million One Hundred Twenty Nine Thousand Three Hundred Eight
4898  ====  MMMMDCCCXCVIII
60053693  ====  Six Crore Fifty Three Thousand Six Hundred Ninety Three
60053693  ====  Sixty Million Fifty Three Thousand Six Hundred Ninety Three
1631  ====  MDCXXXI
937741886  ====  Ninety Three Crore Seventy Seven Lakh Fourty One Thousand Eight Hundred Eighty Six
937741886  ====  Nine Hundred Thirty Seven Million Seven Hundred Fourty One Thousand Eight Hundred Eighty Six
1251  ====  MCCLI
-1711920682  ====  Minus One Arab Seventy One Crore Nineteen Lakh Twenty Thousand Six Hundred Eighty Two
-1711920682  ====  Minus One Billion Seven Hundred Eleven Million Nine Hundred Twenty Thousand Six Hundred Eighty Two
3320  ====  MMMCCCXX
1035100047  ====  One Arab Three Crore Fifty One Lakh Fourty Seven
1035100047  ====  One Billion Thirty Five Million One Hundred Thousand Fourty Seven
3117  ====  MMMCXVII
395584238  ====  Thirty Nine Crore Fifty Five Lakh Eighty Four Thousand Two Hundred Thirty Eight
395584238  ====  Three Hundred Ninety Five Million Five Hundred Eighty Four Thousand Two Hundred Thirty Eight
4262  ====  MMMMCCLXII
2082507027  ====  Two Arab Eight Crore Twenty Five Lakh Seven Thousand Twenty Seven
2082507027  ====  Two Billion Eighty Two Million Five Hundred Seven Thousand Twenty Seven
917  ====  CMXVII
459388315  ====  Fourty Five Crore Ninety Three Lakh Eighty Eight Thousand Three Hundred Fifteen
459388315  ====  Four Hundred Fifty Nine Million Three Hundred Eighty Eight Thousand Three Hundred Fifteen
43  ====  XLIII
1212150678  ====  One Arab Twenty One Crore Twenty One Lakh Fifty Thousand Six Hundred Seventy Eight
1212150678  ====  One Billion Two Hundred Twelve Million One Hundred Fifty Thousand Six Hundred Seventy Eight
2056  ====  MMLVI
-1880527974  ====  Minus One Arab Eighty Eight Crore Five Lakh Twenty Seven Thousand Nine Hundred Seventy Four
-1880527974  ====  Minus One Billion Eight Hundred Eighty Million Five Hundred Twenty Seven Thousand Nine Hundred Seventy Four
374  ====  CCCLXXIV
1490890414  ====  One Arab Fourty Nine Crore Eight Lakh Ninety Thousand Four Hundred Fourteen
1490890414  ====  One Billion Four Hundred Ninety Million Eight Hundred Ninety Thousand Four Hundred Fourteen
3857  ====  MMMDCCCLVII
2041084759  ====  Two Arab Four Crore Ten Lakh Eighty Four Thousand Seven Hundred Fifty Nine
2041084759  ====  Two Billion Fourty One Million Eighty Four Thousand Seven Hundred Fifty Nine
4647  ====  MMMMDCXLVII
-1655044390  ====  Minus One Arab Sixty Five Crore Fifty Lakh Fourty Four Thousand Three Hundred Ninety
-1655044390  ====  Minus One Billion Six Hundred Fifty Five Million Fourty Four Thousand Three Hundred Ninety
1873  ====  MDCCCLXXIII
1236128408  ====  One Arab Twenty Three Crore Sixty One Lakh Twenty Eight Thousand Four Hundred Eight
1236128408  ====  One Billion Two Hundred Thirty Six Million One Hundred Twenty Eight Thousand Four Hundred Eight
4631  ====  MMMMDCXXXI
1026084439  ====  One Arab Two Crore Sixty Lakh Eighty Four Thousand Four Hundred Thirty Nine
1026084439  ====  One Billion Twenty Six Million Eighty Four Thousand Four Hundred Thirty Nine
3568  ====  MMMDLXVIII
1128260523  ====  One Arab Twelve Crore Eighty Two Lakh Sixty Thousand Five Hundred Twenty Three
1128260523  ====  One Billion One Hundred Twenty Eight Million Two Hundred Sixty Thousand Five Hundred Twenty Three
1138  ====  MCXXXVIII
1266149491  ====  One Arab Twenty Six Crore Sixty One Lakh Fourty Nine Thousand Four Hundred Ninety One
1266149491  ====  One Billion Two Hundred Sixty Six Million One Hundred Fourty Nine Thousand Four Hundred Ninety One
4635  ====  MMMMDCXXXV
950734143  ====  Ninety Five Crore Seven Lakh Thirty Four Thousand One Hundred Fourty Three
950734143  ====  Nine Hundred Fifty Million Seven Hundred Thirty Four Thousand One Hundred Fourty Three
3573  ====  MMMDLXXIII
-450994411  ====  Minus Fourty Five Crore Nine Lakh Ninety Four Thousand Four Hundred Eleven
-450994411  ====  Minus Four Hundred Fifty Million Nine Hundred Ninety Four Thousand Four Hundred Eleven
4182  ====  MMMMCLXXXII
-1166732132  ====  Minus One Arab Sixteen Crore Sixty Seven Lakh Thirty Two Thousand One Hundred Thirty Two
-1166732132  ====  Minus One Billion One Hundred Sixty Six Million Seven Hundred Thirty Two Thousand One Hundred Thirty Two
140  ====  CXL
-972893477  ====  Minus Ninety Seven Crore Twenty Eight Lakh Ninety Three Thousand Four Hundred Seventy Seven
-972893477  ====  Minus Nine Hundred Seventy Two Million Eight Hundred Ninety Three Thousand Four Hundred Seventy Seven
1673  ====  MDCLXXIII
-303960370  ====  Minus Thirty Crore Thirty Nine Lakh Sixty Thousand Three Hundred Seventy
-303960370  ====  Minus Three Hundred Three Million Nine Hundred Sixty Thousand Three Hundred Seventy
2183  ====  MMCLXXXIII
-2145840393  ====  Minus Two Arab Fourteen Crore Fifty Eight Lakh Fourty Thousand Three Hundred Ninety Three
-2145840393  ====  Minus Two Billion One Hundred Fourty Five Million Eight Hundred Fourty Thousand Three Hundred Ninety Three
861  ====  DCCCLXI
-948069764  ====  Minus Ninety Four Crore Eighty Lakh Sixty Nine Thousand Seven Hundred Sixty Four
-948069764  ====  Minus Nine Hundred Fourty Eight Million Sixty Nine Thousand Seven Hundred Sixty Four
3985  ====  MMMCMLXXXV
1197686732  ====  One Arab Nineteen Crore Seventy Six Lakh Eighty Six Thousand Seven Hundred Thirty Two
1197686732  ====  One Billion One Hundred Ninety Seven Million Six Hundred Eighty Six Thousand Seven Hundred Thirty Two
2381  ====  MMCCCLXXXI
1739688051  ====  One Arab Seventy Three Crore Ninety Six Lakh Eighty Eight Thousand Fifty One
1739688051  ====  One Billion Seven Hundred Thirty Nine Million Six Hundred Eighty Eight Thousand Fifty One
2410  ====  MMCDXI
-1799784130  ====  Minus One Arab Seventy Nine Crore Ninety Seven Lakh Eighty Four Thousand One Hundred Thirty
-1799784130  ====  Minus One Billion Seven Hundred Ninety Nine Million Seven Hundred Eighty Four Thousand One Hundred Thirty
37  ====  XXXVII
-500500979  ====  Minus Fifty Crore Five Lakh Nine Hundred Seventy Nine
-500500979  ====  Minus Five Hundred Million Five Hundred Thousand Nine Hundred Seventy Nine
921  ====  CMXXI
-1903014386  ====  Minus One Arab Ninety Crore Thirty Lakh Fourteen Thousand Three Hundred Eighty Six
-1903014386  ====  Minus One Billion Nine Hundred Three Million Fourteen Thousand Three Hundred Eighty Six
2435  ====  MMCDXXXV
-1211098760  ====  Minus One Arab Twenty One Crore Ten Lakh Ninety Eight Thousand Seven Hundred Sixty
-1211098760  ====  Minus One Billion Two Hundred Eleven Million Ninety Eight Thousand Seven Hundred Sixty
4847  ====  MMMMDCCCXLVII
1281200218  ====  One Arab Twenty Eight Crore Twelve Lakh Two Hundred Eighteen
1281200218  ====  One Billion Two Hundred Eighty One Million Two Hundred Thousand Two Hundred Eighteen
4434  ====  MMMMCDXXXIV
2144032384  ====  Two Arab Fourteen Crore Fourty Lakh Thirty Two Thousand Three Hundred Eighty Four
2144032384  ====  Two Billion One Hundred Fourty Four Million Thirty Two Thousand Three Hundred Eighty Four
1070  ====  MLXX
1035083419  ====  One Arab Three Crore Fifty Lakh Eighty Three Thousand Four Hundred Nineteen
1035083419  ====  One Billion Thirty Five Million Eighty Three Thousand Four Hundred Nineteen
3451  ====  MMMCDLI
1927267371  ====  One Arab Ninety Two Crore Seventy Two Lakh Sixty Seven Thousand Three Hundred Seventy One
1927267371  ====  One Billion Nine Hundred Twenty Seven Million Two Hundred Sixty Seven Thousand Three Hundred Seventy One
2822  ====  MMDCCCXXII
954087148  ====  Ninety Five Crore Fourty Lakh Eighty Seven Thousand One Hundred Fourty Eight
954087148  ====  Nine Hundred Fifty Four Million Eighty Seven Thousand One Hundred Fourty Eight
3407  ====  MMMCDVII
1031721359  ====  One Arab Three Crore Seventeen Lakh Twenty One Thousand Three Hundred Fifty Nine
1031721359  ====  One Billion Thirty One Million Seven Hundred Twenty One Thousand Three Hundred Fifty Nine
4377  ====  MMMMCCCLXXVII
-296794073  ====  Minus Twenty Nine Crore Sixty Seven Lakh Ninety Four Thousand Seventy Three
-296794073  ====  Minus Two Hundred Ninety Six Million Seven Hundred Ninety Four Thousand Seventy Three
340  ====  CCCXL
1320592291  ====  One Arab Thirty Two Crore Five Lakh Ninety Two Thousand Two Hundred Ninety One
1320592291  ====  One Billion Three Hundred Twenty Million Five Hundred Ninety Two Thousand Two Hundred Ninety One
3470  ====  MMMCDLXX
-28635375  ====  Minus Two Crore Eighty Six Lakh Thirty Five Thousand Three Hundred Seventy Five
-28635375  ====  Minus Twenty Eight Million Six Hundred Thirty Five Thousand Three Hundred Seventy Five
775  ====  DCCLXXV
-1096391047  ====  Minus One Arab Nine Crore Sixty Three Lakh Ninety One Thousand Fourty Seven
-1096391047  ====  Minus One Billion Ninety Six Million Three Hundred Ninety One Thousand Fourty Seven
4751  ====  MMMMDCCLI
18250407  ====  One Crore Eighty Two Lakh Fifty Thousand Four Hundred Seven
18250407  ====  Eighteen Million Two Hundred Fifty Thousand Four Hundred Seven
2548  ====  MMDXLVIII
1033160320  ====  One Arab Three Crore Thirty One Lakh Sixty Thousand Three Hundred Twenty
1033160320  ====  One Billion Thirty Three Million One Hundred Sixty Thousand Three Hundred Twenty
3852  ====  MMMDCCCLII
910711753  ====  Ninety One Crore Seven Lakh Eleven Thousand Seven Hundred Fifty Three
910711753  ====  Nine Hundred Ten Million Seven Hundred Eleven Thousand Seven Hundred Fifty Three
2249  ====  MMCCXLIX
-1585568992  ====  Minus One Arab Fifty Eight Crore Fifty Five Lakh Sixty Eight Thousand Nine Hundred Ninety Two
-1585568992  ====  Minus One Billion Five Hundred Eighty Five Million Five Hundred Sixty Eight Thousand Nine Hundred Ninety Two
2877  ====  MMDCCCLXXVII
147361357  ====  Fourteen Crore Seventy Three Lakh Sixty One Thousand Three Hundred Fifty Seven
147361357  ====  One Hundred Fourty Seven Million Three Hundred Sixty One Thousand Three Hundred Fifty Seven
195  ====  CXCV
-409047966  ====  Minus Fourty Crore Ninety Lakh Fourty Seven Thousand Nine Hundred Sixty Six
-409047966  ====  Minus Four Hundred Nine Million Fourty Seven Thousand Nine Hundred Sixty Six
2389  ====  MMCCCLXXXIX
1323931808  ====  One Arab Thirty Two Crore Thirty Nine Lakh Thirty One Thousand Eight Hundred Eight
1323931808  ====  One Billion Three Hundred Twenty Three Million Nine Hundred Thirty One Thousand Eight Hundred Eight
1171  ====  MCLXXI
1197123561  ====  One Arab Nineteen Crore Seventy One Lakh Twenty Three Thousand Five Hundred Sixty One
1197123561  ====  One Billion One Hundred Ninety Seven Million One Hundred Twenty Three Thousand Five Hundred Sixty One
2626  ====  MMDCXXVI
-406981938  ====  Minus Fourty Crore Sixty Nine Lakh Eighty One Thousand Nine Hundred Thirty Eight
-406981938  ====  Minus Four Hundred Six Million Nine Hundred Eighty One Thousand Nine Hundred Thirty Eight
2881  ====  MMDCCCLXXXI
-780116514  ====  Minus Seventy Eight Crore One Lakh Sixteen Thousand Five Hundred Fourteen
-780116514  ====  Minus Seven Hundred Eighty Million One Hundred Sixteen Thousand Five Hundred Fourteen
2947  ====  MMCMXLVII
-1339859047  ====  Minus One Arab Thirty Three Crore Ninety Eight Lakh Fifty Nine Thousand Fourty Seven
-1339859047  ====  Minus One Billion Three Hundred Thirty Nine Million Eight Hundred Fifty Nine Thousand Fourty Seven
1508  ====  MDVIII
-1596684780  ====  Minus One Arab Fifty Nine Crore Sixty Six Lakh Eighty Four Thousand Seven Hundred Eighty
-1596684780  ====  Minus One Billion Five Hundred Ninety Six Million Six Hundred Eighty Four Thousand Seven Hundred Eighty
2213  ====  MMCCXIII
1629609971  ====  One Arab Sixty Two Crore Ninety Six Lakh Nine Thousand Nine Hundred Seventy One
1629609971  ====  One Billion Six Hundred Twenty Nine Million Six Hundred Nine Thousand Nine Hundred Seventy One
384  ====  CCCLXXXIV
-229229654  ====  Minus Twenty Two Crore Ninety Two Lakh Twenty Nine Thousand Six Hundred Fifty Four
-229229654  ====  Minus Two Hundred Twenty Nine Million Two Hundred Twenty Nine Thousand Six Hundred Fifty Four
1050  ====  MLI
1169579730  ====  One Arab Sixteen Crore Ninety Five Lakh Seventy Nine Thousand Seven Hundred Thirty
1169579730  ====  One Billion One Hundred Sixty Nine Million Five Hundred Seventy Nine Thousand Seven Hundred Thirty
902  ====  CMII
-1173898197  ====  Minus One Arab Seventeen Crore Thirty Eight Lakh Ninety Eight Thousand One Hundred Ninety Seven
-1173898197  ====  Minus One Billion One Hundred Seventy Three Million Eight Hundred Ninety Eight Thousand One Hundred Ninety Seven
2716  ====  MMDCCXVI
-16398509  ====  Minus One Crore Sixty Three Lakh Ninety Eight Thousand Five Hundred Nine
-16398509  ====  Minus Sixteen Million Three Hundred Ninety Eight Thousand Five Hundred Nine
770  ====  DCCLXX
-2100654958  ====  Minus Two Arab Ten Crore Six Lakh Fifty Four Thousand Nine Hundred Fifty Eight
-2100654958  ====  Minus Two Billion One Hundred Million Six Hundred Fifty Four Thousand Nine Hundred Fifty Eight
2265  ====  MMCCLXV
-595396954  ====  Minus Fifty Nine Crore Fifty Three Lakh Ninety Six Thousand Nine Hundred Fifty Four
-595396954  ====  Minus Five Hundred Ninety Five Million Three Hundred Ninety Six Thousand Nine Hundred Fifty Four
940  ====  CMXL
1768955781  ====  One Arab Seventy Six Crore Eighty Nine Lakh Fifty Five Thousand Seven Hundred Eighty One
1768955781  ====  One Billion Seven Hundred Sixty Eight Million Nine Hundred Fifty Five Thousand Seven Hundred Eighty One
708  ====  DCCVIII
-1867113074  ====  Minus One Arab Eighty Six Crore Seventy One Lakh Thirteen Thousand Seventy Four
-1867113074  ====  Minus One Billion Eight Hundred Sixty Seven Million One Hundred Thirteen Thousand Seventy Four
4225  ====  MMMMCCXXV
1287283334  ====  One Arab Twenty Eight Crore Seventy Two Lakh Eighty Three Thousand Three Hundred Thirty Four
1287283334  ====  One Billion Two Hundred Eighty Seven Million Two Hundred Eighty Three Thousand Three Hundred Thirty Four
4995  ====  MMMMCMXCV
2033245297  ====  Two Arab Three Crore Thirty Two Lakh Fourty Five Thousand Two Hundred Ninety Seven
2033245297  ====  Two Billion Thirty Three Million Two Hundred Fourty Five Thousand Two Hundred Ninety Seven
2606  ====  MMDCVI
1648155596  ====  One Arab Sixty Four Crore Eighty One Lakh Fifty Five Thousand Five Hundred Ninety Six
1648155596  ====  One Billion Six Hundred Fourty Eight Million One Hundred Fifty Five Thousand Five Hundred Ninety Six
2207  ====  MMCCVII
-352564278  ====  Minus Thirty Five Crore Twenty Five Lakh Sixty Four Thousand Two Hundred Seventy Eight
-352564278  ====  Minus Three Hundred Fifty Two Million Five Hundred Sixty Four Thousand Two Hundred Seventy Eight
939  ====  CMXXXIX
-680377807  ====  Minus Sixty Eight Crore Three Lakh Seventy Seven Thousand Eight Hundred Seven
-680377807  ====  Minus Six Hundred Eighty Million Three Hundred Seventy Seven Thousand Eight Hundred Seven
2788  ====  MMDCCLXXXVIII
1593251962  ====  One Arab Fifty Nine Crore Thirty Two Lakh Fifty One Thousand Nine Hundred Sixty Two
1593251962  ====  One Billion Five Hundred Ninety Three Million Two Hundred Fifty One Thousand Nine Hundred Sixty Two
1196  ====  MCXCVI
1343026219  ====  One Arab Thirty Four Crore Thirty Lakh Twenty Six Thousand Two Hundred Nineteen
1343026219  ====  One Billion Three Hundred Fourty Three Million Twenty Six Thousand Two Hundred Nineteen
4049  ====  MMMMXLIX
1383638997  ====  One Arab Thirty Eight Crore Thirty Six Lakh Thirty Eight Thousand Nine Hundred Ninety Seven
1383638997  ====  One Billion Three Hundred Eighty Three Million Six Hundred Thirty Eight Thousand Nine Hundred Ninety Seven
1225  ====  MCCXXV
-1030110432  ====  Minus One Arab Three Crore One Lakh Ten Thousand Four Hundred Thirty Two
-1030110432  ====  Minus One Billion Thirty Million One Hundred Ten Thousand Four Hundred Thirty Two
4189  ====  MMMMCLXXXIX
-373007151  ====  Minus Thirty Seven Crore Thirty Lakh Seven Thousand One Hundred Fifty One
-373007151  ====  Minus Three Hundred Seventy Three Million Seven Thousand One Hundred Fifty One
798  ====  DCCXCVIII
-1901365034  ====  Minus One Arab Ninety Crore Thirteen Lakh Sixty Five Thousand Thirty Four
-1901365034  ====  Minus One Billion Nine Hundred One Million Three Hundred Sixty Five Thousand Thirty Four
1165  ====  MCLXV
721786027  ====  Seventy Two Crore Seventeen Lakh Eighty Six Thousand Twenty Seven
721786027  ====  Seven Hundred Twenty One Million Seven Hundred Eighty Six Thousand Twenty Seven
2799  ====  MMDCCXCIX
1469289996  ====  One Arab Fourty Six Crore Ninety Two Lakh Eighty Nine Thousand Nine Hundred Ninety Six
1469289996  ====  One Billion Four Hundred Sixty Nine Million Two Hundred Eighty Nine Thousand Nine Hundred Ninety Six
4430  ====  MMMMCDXXX
-1242139106  ====  Minus One Arab Twenty Four Crore Twenty One Lakh Thirty Nine Thousand One Hundred Six
-1242139106  ====  Minus One Billion Two Hundred Fourty Two Million One Hundred Thirty Nine Thousand One Hundred Six
2590  ====  MMDXC
896422896  ====  Eighty Nine Crore Sixty Four Lakh Twenty Two Thousand Eight Hundred Ninety Six
896422896  ====  Eight Hundred Ninety Six Million Four Hundred Twenty Two Thousand Eight Hundred Ninety Six
2819  ====  MMDCCCXIX
150304343  ====  Fifteen Crore Three Lakh Four Thousand Three Hundred Fourty Three
150304343  ====  One Hundred Fifty Million Three Hundred Four Thousand Three Hundred Fourty Three
4932  ====  MMMMCMXXXII
1121012550  ====  One Arab Twelve Crore Ten Lakh Twelve Thousand Five Hundred Fifty
1121012550  ====  One Billion One Hundred Twenty One Million Twelve Thousand Five Hundred Fifty
2982  ====  MMCMLXXXII
373625380  ====  Thirty Seven Crore Thirty Six Lakh Twenty Five Thousand Three Hundred Eighty
373625380  ====  Three Hundred Seventy Three Million Six Hundred Twenty Five Thousand Three Hundred Eighty
3791  ====  MMMDCCXCI
-1017115469  ====  Minus One Arab One Crore Seventy One Lakh Fifteen Thousand Four Hundred Sixty Nine
-1017115469  ====  Minus One Billion Seventeen Million One Hundred Fifteen Thousand Four Hundred Sixty Nine
4990  ====  MMMMCMXC
-1414412345  ====  Minus One Arab Fourty One Crore Fourty Four Lakh Twelve Thousand Three Hundred Fourty Five
-1414412345  ====  Minus One Billion Four Hundred Fourteen Million Four Hundred Twelve Thousand Three Hundred Fourty Five
1239  ====  MCCXXXIX
-2045015663  ====  Minus Two Arab Four Crore Fifty Lakh Fifteen Thousand Six Hundred Sixty Three
-2045015663  ====  Minus Two Billion Fourty Five Million Fifteen Thousand Six Hundred Sixty Three
