using System;

/* This class goes over Lesson 17 Content
Delegates, Events & Lambdas */
namespace CSharpClass.Lessons
{
    public class Lesson17
    {
        public string HatType {get; private set;}
        public int HatSize {get; private set;}
        public string MyResult {get; private set;}

        private string _prop;
        public string MyProperty
        {
            // (parameters) => expression-or-statement block
            get => _prop;
            set => _prop = value;
        } // end method my property example

        public delegate void TryOnAnotherHat(string hat);
        public delegate string TryFavoriteHat(string fav);
        delegate int del(int beta);
        public event TryFavoriteHat MyEventHat;

        public Lesson17()
        {
            TryOnAnotherHat otherHat = TryOnHat;
            TryALargerHat("Bowler", 9, otherHat);
        } // end second method lesson 17

        public Lesson17(string type, int size)
        {
            HatType = type;
            HatSize = size;
        } // end method lesson 17

        public Lesson17(string type)
        {
            MyEventHat += new TryFavoriteHat(this.MyFavoriteHat);
            MyResult = MyEventHat(type);
        } // end method third lesson 17

        public string MyFavoriteHat(string message)
        {
            return "My favorite hat is a " + message;
        } // end method try favorite hat

        public void TryALargerHat(string type, int oldSize, TryOnAnotherHat another)
        {
            another("I tried on a " + type + " hat a size " + (++oldSize));
        } // end method try a larger hat

        public void TryOnHat(string message)
        {
            Console.WriteLine(message);
        } // end method try on hat

        public int MyLambdaExample(int value)
        {
            // (parameters) => expression for statement block
            del myDelegate = x => x * x;
            return myDelegate(value);
        } // end method my lambda example




    } // end class
} // end namespace