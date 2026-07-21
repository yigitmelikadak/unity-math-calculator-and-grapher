using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImgManager : MonoBehaviour
{
    public RawImage raw;
    bool once;
    private void Update()
    {
        if (raw.IsActive() && !once)
        {
            Vector3 v = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
            float w = v.x * 2; float h = v.y * 2;
            float x = -(w % 1) / 2; float y = 0;
            raw.uvRect = new Rect(x, y, w, h);
            once = true;
        } 
    }
}
