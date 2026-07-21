using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointManager : MonoBehaviour
{
    bool yeto = false;
    public GameObject a;
    public void oyoy()
    {
        yeto = !yeto;
        if (yeto == false)
        {
            a.SetActive(false);
        }
        else
        {
            a.SetActive (true);
        }
    }
}
