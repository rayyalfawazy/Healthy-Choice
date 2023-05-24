using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MakeInvisibleLocked()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MakeVisibleUnlocked()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
