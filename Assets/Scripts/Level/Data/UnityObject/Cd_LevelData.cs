﻿using Data.ValueObject;
using System.Collections.Generic;
using UnityEngine;

namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "Cd_LevelData", menuName = "Data/LevelData")]
    public class Cd_LevelData : ScriptableObject
    {
        //public LevelData levelData;
        public List<LevelDatas> LevelData = new List<LevelDatas>();
    }
}