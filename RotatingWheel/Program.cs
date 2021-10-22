using System;
using System.Threading;

namespace RotatingWheel
{
    class Program
    {
        static int dir = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(TocKolieskom("janko"));
                Console.SetCursorPosition(0, 0);
                Thread.Sleep(100);
            }
        }

        static string TocKolieskom(string x)
        {
            string ixi = "";
            switch(dir)
            {
                case 0:
                    ixi =   "                          \n" +
                            "         -------          \n" +
                            "       ---     ---        \n" +
                            "     ---         ---      \n" +
                           $"     ---    O------- {x}  \n" +
                            "     ---         ---      \n" +
                            "       ---     ---        \n" +
                            "         -------          \n" +
                            "                          \n";
                    break;
                case 1:
                    ixi =   "                          \n" +
                            "         -------          \n" +
                            "       ---     ---        \n" +
                            "     ---         ---      \n" +
                            "     ---    O    ---      \n" +
                            "     ---      \\  ---      \n" +
                           $"       ---     --- {x}   \n" +
                            "         -------          \n" +
                            "                          \n";
                    break;
                case 2:
                    ixi =   "                          \n" +
                            "         -------          \n" +
                            "       ---     ---        \n" +
                            "     ---         ---      \n" +
                            "     ---    O    ---      \n" +
                            "     ---    |    ---      \n" +
                            "       ---  |  ---        \n" +
                            "         -------          \n" +
                           $"           {x}            \n";
                    break;
                case 3:
                    ixi =   "                           \n" +
                            "          -------          \n" +
                            "        ---     ---        \n" +
                            "      ---         ---      \n" +
                            "      ---    O    ---      \n" +
                            "      ---  /      ---      \n" +
                           $"{x}   ---     ---        \n" +
                            "          -------          \n" +
                            "                           \n";
                    break;
                case 4:
                    ixi = "                            \n" +
                          "           -------          \n" +
                          "         ---     ---        \n" +
                          "       ---         ---      \n" +
                         $"{x}  -------O    ---      \n" +
                          "       ---         ---      \n" +
                          "         ---     ---        \n" +
                          "           -------          \n" +
                          "                            \n";
                    break;
                case 5:
                    ixi =   "                          \n" +
                            "         -------          \n" +
                           $"{x}  ---     ---        \n" +
                            "     ---  \\      ---      \n" +
                            "     ---    O    ---      \n" +
                            "     ---         ---      \n" +
                            "       ---     ---        \n" +
                            "         -------          \n" +
                            "                          \n";
                    break;
                case 6:
                    ixi =  $"           {x}            \n" +
                            "         -------          \n" +
                            "       ---  |  ---        \n" +
                            "     ---    |    ---      \n" +
                            "     ---    O    ---      \n" +
                            "     ---         ---      \n" +
                            "       ---     ---        \n" +
                            "         -------          \n" +
                            "                          \n";

                    break;
                case 7:
                    ixi =   "                          \n" +
                            "         -------          \n" +
                           $"       ---     --- {x}    \n" +
                            "     ---      /  ---      \n" +
                            "     ---    O    ---      \n" +
                            "     ---         ---      \n" +
                            "       ---     ---        \n" +
                            "         -------          \n" +
                            "                          \n";
                    break;
            }
            dir = (dir + 1) % 8;
            return ixi;
        }
    }
}
