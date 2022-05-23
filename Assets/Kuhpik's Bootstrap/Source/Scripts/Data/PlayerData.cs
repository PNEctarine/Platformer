using NaughtyAttributes;
using System;
using UnityEngine;

namespace Kuhpik
{
    /// <summary>
    /// Used to store player's data. Change it the way you want.
    /// </summary>
    [Serializable]
    public class PlayerData
    {
        public int Level;
        public int LevelToLoad;

        public GameObject CurrentLevel;
        // Example (I use public fields for data, but u free to use properties\methods etc)
        // [BoxGroup("level")] public int level;
        // [BoxGroup("currency")] public int money;
    }
}