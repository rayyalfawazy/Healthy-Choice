using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "LevelData")]
public class StageData : ScriptableObject
{
    public string stageName;

    public Sprite backgroundImage;

    public int targetObjective;

    public float minFallSpeedValue;
    public float maxFalSpeedValue;
}
