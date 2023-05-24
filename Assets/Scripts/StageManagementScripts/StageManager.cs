using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public List<StageData> stageDatas;
    public StageButton stageButton;
    public Transform stageParent;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < stageDatas.Count; i++) 
        {
            stageButton.level = i;
            Instantiate(stageButton, stageParent);
        }
    }
}
