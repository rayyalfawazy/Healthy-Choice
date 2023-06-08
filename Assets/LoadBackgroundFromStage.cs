using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadBackgroundFromStage : MonoBehaviour
{
    public PlayManager playManager;
    public RawImage background;

    public void ChangeBackground()
    {
        playManager.GetStageData();
        background.texture = playManager.backgroundImage;
    }
}
