using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;
using UnityEngine.UIElements;

public class ScriptF6 : MonoBehaviour
{
    public TMP_InputField[] fields;
    TMP_InputField tmp;
    public TextMeshProUGUI info;
    public TextMeshProUGUI kacTane;
    private void Start()
    {
        tmp = fields[0];
    }
    public void ItsZero()
    {
        tmp = fields[0];
    }
    public void ItsOne()
    {
        tmp = fields[1];
    }
    public void ItsSurprisinglyTwo()
    {
        tmp = fields[2];
    }
    public void ButtonDelete()
    {
        if (tmp.text != "")
        {
            tmp.text = tmp.text.Remove(tmp.text.Length - 1);
        }
    }
    public void Button1()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "1";
        }
    }
    public void Button2()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "2";
        }
    }
    public void Button3()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "3";
        }
    }
    public void Button4()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "4";
        }
    }
    public void Button5()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "5";
        }
    }
    public void Button6()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "6";
        }
    }
    public void Button7()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "7";
        }
    }
    public void Button8()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "8";
        }
    }
    public void Button9()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "9";
        }
    }
    public void Button0()
    {
        if (tmp.characterLimit > tmp.text.Length)
        {
            tmp.text += "0";
        }
    }
    public GameObject panelF;
    public GameObject panelE;
    public void PanelFunction()
    {
        panelF.SetActive(true);
        panelE.SetActive(false);
    }

    public void PanelExperimental()
    {
        panelE.SetActive(true);
        panelF.SetActive(false);
    }

    public void TurnBack()
    {
        panelF.SetActive(false);
        panelE.SetActive(false);
    }

    public void ebob() { SceneManager.LoadScene("F0"); }
    public void ekok() { SceneManager.LoadScene("F1"); }
    public void asalmi() { SceneManager.LoadScene("F2"); }
    public void kalanbul() { SceneManager.LoadScene("F3"); }
    public void kesrisadelestir() { SceneManager.LoadScene("F4"); }
    public void ax2() { SceneManager.LoadScene("F5"); }
    public void axby() { SceneManager.LoadScene("F6"); }
    public void grafik() { SceneManager.LoadScene("E0"); }
    public void geometri() { SceneManager.LoadScene("E1"); }
    public void temel() { SceneManager.LoadScene("Main"); }

    public void ButtonC()
    {
        tmp.text = "";
    }

    public void Result()
    {
        if (fields[0].text != "" && fields[1].text != "" && fields[2].text != "")
        {
            long a = long.Parse(fields[0].text);
            long b = long.Parse(fields[1].text);
            long c = long.Parse(fields[2].text);
            List<Vector2> list = new List<Vector2>();
            for (int i = 0; i < c; i++)
            {
                if ((c - i * a) % b == 0 && (c - (a * i)) / b >= 0)
                {
                    long x = i;
                    long y = (c - (a * i)) / b;
                    Vector2 vector2 = new Vector2(x, y);
                    list.Add(vector2);
                }
            }
            info.text = "";
            kacTane.text = list.Count + " tane ikili vardýr.";
            int sayi = Mathf.CeilToInt(list.Count / 4);
            int isayi = 0;
            foreach (var item in list)
            {
                info.text += "(" + item.x + "," + item.y + "), ";
                isayi++;
                if (isayi > sayi)
                {
                    info.text += "\n";
                    isayi = 0;
                }
            }
            if (info.text != "")
            {
                info.text = info.text.Remove(info.text.Length - 1);
                info.text = info.text.Remove(info.text.Length - 1);
            }
        }
    }
}
