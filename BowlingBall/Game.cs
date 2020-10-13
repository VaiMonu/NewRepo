using System.Collections.Generic;
using System.Linq;

namespace BowlingBall
{
    public class Game
    {
        /* Key points I taken care of while doing development
         1.Single Responsbility for game class.
         2. Used Yield Keyword used for custom stateful itereation on list collection.
         3.Created Extension method to add Logic for Better code mainatinablity.
         4. Avoid looping.
         5.Used comments so developer can understand.
         6.Removed Extra Namespace
         */

        private readonly List<Frame> _frames = new List<Frame>();

        public int Score()
        {
            Add(new Open(0, 0));
            Add(new Open(0, 0));

            for (int i = 0; i < 10; i++)
                _frames[i].AddBonus(_frames[i + 1], _frames[i + 2]);

            int counter = 0;
            _frames.ForEach(frame => counter += frame.Score());
            return counter;
        }

        public void Roll(int firstRoll, int secondRoll)
        {
            if (!GameFinished())
            {
                Add(Frame.Create(firstRoll, secondRoll));
            }
        }

        public void RollStrike()
        {
            Roll(10, 0);
        }

        private bool GameFinished()
        {
            return _frames.Count.Equals(10);
        }

        private void Add(Frame frame)
        {
            _frames.Add(frame);
        }

        public void RollLastFrame(int firstRoll, int secondRoll, int thirdRoll)
        {
            Add(Frame.Create(firstRoll, secondRoll, thirdRoll));
        }
    }
}