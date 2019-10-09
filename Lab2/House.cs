using System;
namespace CSharpClass
{
    /*This class demostrates the basic object of House
    Lesson 4 - My Application Overview */
    public class House
    {
        int _windowSize;
        string _foundation;
        string _roofType;
        string _doorColor;

        public int windowSize
        {
            get
            {
                return _windowSize;
            }
            set
            {
                _windowSize = value;
            }
        } // end window size

        public string Foundation
        {
            get { return _foundation; }
            set { _foundation = value; }
        } // end foundation

        public string RoofType { get; set; }

        public string DoorColor { get; private set; }

        public House() 
            : this(24, "slate")
        { }

        public House(int windowSize, string foundation)
            : this(windowSize, foundation, "shingle", "green")
        {

        }

        public House(int windowSize, string foundation, string
        roofType, string doorColor)
        {
            this._windowSize = windowSize;
            this._foundation = foundation;
            RoofType = roofType;
            DoorColor = doorColor;
        } // end house
        public virtual void DoorOpenClose()
        {
            Console.WriteLine("The door is ajar");
            this.DoorOpenClose("teal");
        } // end method door open close

        public void DoorOpenClose(string doorColor)
        {
            Console.WriteLine("My door is {0}", doorColor);
        } // end method door color


    } // end class
} // end namespace