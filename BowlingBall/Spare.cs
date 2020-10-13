using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Spare : Frame
    {
        public Spare(int firstRoll, int secondRoll) : base(firstRoll, secondRoll) { }

        public override void AddBonus(Frame framePlusOne, Frame framePlusTwo)
        {
            _frameScore += framePlusOne.FirstRoll();
        }
    }
}
