using System;

namespace FrozenPhoenix.DataStructures
{
    [Serializable]
    public class IntRange
    {
        public int Min;
        public int Max;

        public IntRange(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
}