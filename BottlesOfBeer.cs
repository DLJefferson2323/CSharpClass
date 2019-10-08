using System;


/*This class will sing a song while using different statements*/
namespace CSharpClass
{
    public class BottlesOfBeer
    {
        int _beerNum = 99;
        string _word = "bottles", _result;

        public string LetsSing()
        {
            while (_beerNum > 0)
            {
                if(_beerNum == 1)
                {
                    _word = "bottle";
                } // end if

                Console.WriteLine("{0} {1} of beer on the wall",_beerNum,_word);
                Console.WriteLine("{0} {1} of beer",_beerNum,_word);
                Console.WriteLine("Take one down");
                Console.WriteLine("Pass it around");

                _beerNum--;
                if(_beerNum > 0)
                {
                    Console.WriteLine("{0} {1} of beer on the wall",_beerNum,_word);
                    Console.WriteLine();
                } // end if

                else
                {
                    _result = "No more bottles of beer on the wall.";
                } // end else

            } // end method while statement

            return _result;

        } // end method lets sing
    } // end class
} // end namespace