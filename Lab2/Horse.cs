using System;

namespace CSharpClass.Lab2
{
    public class Horse
    {
        int _hooves;
        string _tail;
        string _softhair;
        string _largebody;

        public virtual void Racing()
        {
            Console.WriteLine("The horse is racing");
        } // end method racing

        public void wrangling(string largeBody)
        {

        } // end method wrangling

        public string Tail
        {
            get { return _tail;}
            set { _tail = value;}
        } // end tail

        public string Softhair 
        {
            get { return _softhair;}
            set { _softhair = value;}
        } // end softhair

        public string LargeBody 
        {
            get { return _largebody;}
            set { _largebody = value;}
        } // end softhair

        public int Hooves
        {
            get
            {
                return _hooves;
            }
            set
            {
                _hooves = value;
            }
        } // end hooves

        public Horse (int hooves, string largebody, string softhair, string tail)
        {
            this._hooves = hooves;
            this._tail = tail;
            this._largebody = largebody;
            this._softhair = softhair;
        }

        public Horse()
        {
            
        }

    } // end class
} // end namespace