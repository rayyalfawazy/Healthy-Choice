using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "LevelData")]
public class StageData : ScriptableObject
{
    public string stageName;

    public Texture2D stageBackgroundImage;

    public int targetObjective;
    public int spawnDelay;

    public float minFallSpeedValue;
    public float maxFalSpeedValue;
}
