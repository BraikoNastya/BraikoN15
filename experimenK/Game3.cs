using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraikoN15
{
    class Game3 : Game2
    {
        public readonly List<int> stepsPlayer;

        public Game3(params int[] field) : base(field)
        {
            stepsPlayer = new List<int>();

        }
        public override bool Shift(int value)
        {
            base.Shift(value);
            stepsPlayer.Add(value);
        }
        public void Rollback()
        {
            int lastStep = stepsPlayer.Last();
            stepsPlayer.Remove(lastStep);
            this.Shift(lastStep);
        }
    }
