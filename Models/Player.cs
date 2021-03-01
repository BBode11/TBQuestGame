using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    /// <summary>
    /// Player class with inheritance from character class
    /// </summary>
    public class Player: Character
    {
        #region FIELDS

        private int _health;
        private int _lives;
        private int _currency;

        #endregion

        #region PROPERTIES
        public int Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }


        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }


        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        #endregion
        #region CONSTRUCTORS



        #endregion
        #region METHODS

        public override string DefaultPlayerGreeting()
        {
            return $"Hello my name is {_name} and I am looking for materials.";
        }

        #endregion
    }
}
