using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question04
{
    class FootBall
    {
        private DisplayInformation displayInfoInstance;

        public Football()
        {
            displayInfoInstance = new DisplayInformation();
            displayInfoInstance.DisplayDateAfterEvent += DisplayInfoInstance_DisplayDateAfterEvent;
            displayInfoInstance.DisplayMessageBeforeEvent += DisplayInfoInstance_DisplayMessageBeforeEvent;
        }

        private void DisplayInfoInstance_DisplayMessageBeforeEvent() {
            Console.WriteLine("Program is about to display information...");
        }

        public void DisplayInfoInstance_DisplayDateAfterEvent() {
            Console.WriteLine("Information has been display on " + DateTime.Now.ToShortTimeString());
        }

        public void DisplayClub(string club, string country) {
            displayInfoInstance.DisplayClub(club, country);
        }

        public void DisplayPlayerInformation(string name, string club) {
            displayInfoInstance.DisplayPlayer(name, club);
        }
    }
}
