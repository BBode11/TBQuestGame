using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.DataLayer
{
    public class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                ID = 1,
                Name = "Brandon",
                Age = 24,
                LocationId = 0,
                Health = 100,
                Lives = 3,
                Currency = 125
            };
        }

        public static List<string> StartUpMessage()
        {
            return new List<string>()
            {
                "After getting laid off of work you decided you wanted to do some home improvements in your spare time." +
                "The only thing is you do not have all the tools and materials you need." +
                "You decided to go to the hardware store just down the road." +
                "You don't know it yet, but it is about to be the experience of your lifetime."
            };
        }
    }
}
