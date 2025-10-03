using System.Collections.Generic;
using UnityEngine;

namespace KP.QuickKit
{
    public static class WaitForSecondsCache
    {
        private static readonly Dictionary<float, WaitForSeconds> _cache = new();

        public static WaitForSeconds Get(float seconds)
        {
            if (!_cache.ContainsKey(seconds))
            {
                _cache[seconds] = new WaitForSeconds(seconds);
            }

            return _cache[seconds];
        }
    }
}