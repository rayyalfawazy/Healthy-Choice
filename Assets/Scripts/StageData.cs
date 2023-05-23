using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData")]
public class StageData : ScriptableObject
{
    public string stageName;

    public int targetObjective;

    public float baseMinValue;
    public float baseMaxValue;
}
