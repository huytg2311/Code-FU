using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question04
{
    class DisplayInformation
    {
        public delegate void DisplayDateAfterDelegate();
        public delegate void DisplayMessageBeforeDelegate();

        public event DisplayDateAfterDelegate DisplayDateAfterEvent;
        public event DisplayMessageBeforeDelegate DisplayMessageBeforeEvent;

        public void DisplayClub(string clubName, string country) {
            DisplayMessageBeforeEvent();
            Console.WriteLine($"{clubName} from {country}");
            DisplayDateAfterEvent();
            Console.WriteLine();
        }

        public void DisplayPlayer(string playerName, string clubName) {
            DisplayMessageBeforeEvent();
            Console.WriteLine($"{playerName} plays for {clubName}");
            DisplayDateAfterEvent();
        }
    }
}
