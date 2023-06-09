using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public List<StageData> stageDatas;
    public StageButton stageButton;
    public Transform stageParent;

    void Start()
    {
        for(int i = 0; i < stageDatas.Count; i++) 
        {
            stageButton.level = i;
            Instantiate(stageButton, stageParent);
        }
    }
}
