using G_NET_27_OOP_5.Interfaces;

namespace G_NET_27_OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //interface => defines a contract that a class must follow. It specifies what a class can do, not how it does it.
            // To follow two important Principle
            //(1):Program to an interface, not an implementation
            //(2):Dependency Inversion Principle

            // Enable polymorphism without inheritance
            // Remove tight coupling between classes
            // Enable multiple inheritance. 

            #endregion

            #region Q2
            ////proplem:Both IEnglishSpeaker and IArabicSpeaker have a method with the same signature Greet().
            //// Solution : by using Expilict interface Implementation to give each interface its own separate version.
            //// No — you cannot call Greet() directly on a Translator object because with Explicit Interface Implementation,
            ////the method belongs to the interface not the class
            //Translator translator = new Translator();

            //IEnglishSpeaker englishspeaker = translator;
            //IArabicSpeakercs arabicSpeakercs = translator;
            //englishspeaker.Greet();
            //arabicSpeakercs.Greet();
            #endregion

            #region Q3
            // A : Shallow Copy :  copies the object but copies references for reference-type fields.
            // Deep Copy :copies the object and all nested objects, creating fully independent duplicates.

            // B : Shallow :object is immutable, no nested reference state
            // Deep :objects must be isolated, modifications should not affect original.

            // C: The risk is that both the original and the copied object share the same reference-type fields in memory,
            // so changing the field through one object affects the other.
            #endregion
        }
    }
}
