using System;

namespace FrozenPhoenix.DataStructures
{
    [Serializable]
    public class FloatRange
    {
        public float Min;
        public float Max;

        public FloatRange(float min, float max)
        {
            Min = min;
            Max = max;
        }
    }
}