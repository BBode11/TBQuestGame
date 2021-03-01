using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.PresentationLayer
{
    public class GameSessionViewModel
    {
        #region FIELDS

        private Player _player;
        private List<string> _messages;

        #endregion
        #region PROPERTIES
        /// <summary>
        /// return the list of strings with new lines between each message
        /// </summary>
        public string MessageDisplay
        {
            get { return string.Join("\n\n", _messages); }
        }


        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        #endregion
        #region CONSTRUCTORS

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(Player player, List<string> startUpMessage)
        {
            _player = player;
            _messages = startUpMessage;
        }

        #endregion
    }
}
