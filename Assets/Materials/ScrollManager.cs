using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScrollManager : MonoBehaviour
{
    public TextMeshProUGUI sayi;
    public Slider slider;
    public static int i;

    public Button button;
    public static bool isActive;
    Image c, d;
    Image buton;
    public Sprite a, b;
    public GameObject raw;
    private void Awake()
    {
        buton = button.GetComponent<Image>();
    }

    private void Update()
    {
        if (slider.value != i)
        {
            sayi.text = slider.value.ToString();
            i = (int)slider.value;
        }
        if (isActive && button.image != a)
        {
            buton.sprite = a;
            raw.SetActive(true);
        }
        if(!isActive && button.image != b)
        {
            buton.sprite = b;
            raw.SetActive(false);
        }
    }

    public void Change()
    {
        isActive = !isActive;
        ScriptE1.anyupdates = true;
        KoseManager.vaow = true;
    }
}
