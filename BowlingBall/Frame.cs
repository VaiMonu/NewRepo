using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public abstract class Frame
    {
        protected int _pinsFirstRoll;
        protected int _pinsSecondRoll;
        protected int _frameScore;

        protected Frame(int pinsFirstRoll, int pinsSecondRoll)
        {
            _pinsFirstRoll = pinsFirstRoll;
            _pinsSecondRoll = pinsSecondRoll;
        }

        public int Score() { return _pinsFirstRoll + _pinsSecondRoll + _frameScore; }

        public int FirstRoll() { return _pinsFirstRoll; }

        public int SecondRoll() { return _pinsSecondRoll; }

        public static Frame Create(int firstRoll, int secondRoll)
        {
            if (firstRoll == 10)
                return new Strike();

            if ((firstRoll + secondRoll) == 10)
                return new Spare(firstRoll, secondRoll);

            return new Open(firstRoll, secondRoll);
        }

        public static Frame Create(int firstRoll, int secondRoll, int thirdRoll)
        {
            return new Final(firstRoll, secondRoll, thirdRoll);
        }

        public virtual void AddBonus(Frame framePlusOne, Frame framePlusTwo) { }

        public void AddBonus(int points)
        {
            _frameScore += points;
        }
    }
}
