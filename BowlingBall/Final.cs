using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Final : Frame
    {
        private readonly int _pinsThirdRoll;

        public Final(int pinsFirstRoll, int pinsSecondRoll, int pinsThirdRoll) : base(pinsFirstRoll, pinsSecondRoll)
        {
            _pinsThirdRoll = pinsThirdRoll;
        }

        public override void AddBonus(Frame framePlusOne, Frame framePlusTwo)
        {
            _frameScore += _pinsThirdRoll;
        }

    }
}
