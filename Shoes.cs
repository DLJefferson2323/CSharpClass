using System;

/*This lab is for Lesson 12 */
namespace CSharpClass.Lessons
{
    public class Shoes
    {
        int _laces;
        string _eyelets;
        string _soles;

    public int Laces { get; set; }
    public string Eyelets { get; set; }
    public string Soles { get; set; }

    public virtual void Shoesworn()
    {
        Console.WriteLine("These shoes are worn");
    } // end method worn

    public void Worn(int laces)
    {

    } // end method worn

    } // end class
} // end namespace