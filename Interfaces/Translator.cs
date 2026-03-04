using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_5.Interfaces
{
    internal class Translator : IEnglishSpeaker, IArabicSpeakercs
    {
        void IEnglishSpeaker.Greet()
        {
            Console.WriteLine("Hello");
        }

        void IArabicSpeakercs.Greet()
        {
            Console.WriteLine("Ahlan");
        }
    }
}
