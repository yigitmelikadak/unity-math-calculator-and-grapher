using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoseManager : MonoBehaviour
{
    bool isDown;
    public GameObject canva;
    bool update;
    public static bool vaow;
    float x, y;
    private void OnEnable()
    {
        x = transform.position.x; y = transform.position.y;
    }
    public void Down()
    {
        isDown = true;
    }
    public void Up()
    {
        isDown = false;
    }

    private void Update()
    {
        if (vaow)
        {
            if (ScrollManager.isActive)
            {
                Vector3 aman = new Vector3((int)x, (int)y, 0);
                canva.transform.position = aman;
                update = true;
                vaow = false;
            } else
            {
                Vector3 aman = new Vector3(x, y, 0);
                canva.transform.position = aman;
                update = true;
                vaow = false;
            }
        }
        if (ScrollManager.isActive)
        {
            if (isDown && Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                x += touch.deltaPosition.x * Time.deltaTime / 2;
                y += touch.deltaPosition.y * Time.deltaTime / 2;
                Vector3 aman = new Vector3((int)x, (int)y, 0);
                canva.transform.position = aman;
                update = true;
            }
        }
        if (!ScrollManager.isActive)
        {
            if (isDown && Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                x += touch.deltaPosition.x * Time.deltaTime / 2;
                y += touch.deltaPosition.y * Time.deltaTime / 2;
                Vector3 aman = new Vector3(x, y, 0);
                canva.transform.position = aman;
                update = true;
            }
        }
        if (update)
        {
            ScriptE1.anyupdates = true;
            update = false;
        }
    }
}
