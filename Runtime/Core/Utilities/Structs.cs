using System;

namespace KP.QuickKit
{
    public struct Void { }

    [Serializable]
    public struct RangedFloat
    {
        public float minValue;
        public float maxValue;
    }
}