using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page23
{
    class Card
    {
        // private fields for backing storage 
        private int _suit;
        private int _value;
        private bool _facing;
        // constructors (2) :  
        public Card(int number)
        {
            Value = number;                       
        }
        public Card(int faceValue,
                    int suit,
                    bool facing)
        {
            Value = faceValue;
            Suit = suit;
            Facing = facing;
        }
        // public properties
        public int Value
        {
            
            get 
            {
                // what should this really return?
                return _value; 
            }
            set
            {
                _value = value;
            }

        }
        public int Suit
        {
            get
            {
                // what should this really return?
                return _suit;
            }
            set
            {
                _suit = value;
            }
        }
        public bool Facing
        {
            get
            {
                // what should this really return?
                return true;
            }
            set
            {
                _facing = value;
            }
        }
        // methods 
        public void Flip()
        {
            // what goes here
        }
        public void Reveal()
        {
            // what goes here
        }
        public void Hide()
        {
            // what goes here
        }
        public override string ToString()
        {
            // this method is actually implemented correctly


            // condition?true-stuff:false-stuff;

            // facing is the condition: 
            //   it is either true (show)
            //   or false (hide)
            // "A23456789TJQK"[Value] is the 
            //   character to return 
            //   if facing is true
            // '?' is the character to 
            //   return if facing is false

            // similar thing for suit

            char v = Facing
                     ? "A23456789TJQK"[Value]
                     : '?';
            char s = Facing
                     ? "CDHS"[Suit]
                     : '?';

            return $"{v}{s}";
        }

    }



}

