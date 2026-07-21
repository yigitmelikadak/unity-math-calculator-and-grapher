using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using System.Collections.Generic;

public class ScriptF3 : MonoBehaviour
{
    public long Kalan(long a, long b)
    {
        return a % b;
    }

    public TMP_InputField[] fields;
    TMP_InputField tmp;
    public TextMeshProUGUI kalanText, bölümText;
    private void Start()
    {
        tmp = fields[0];
    }
    public void ButtonDelete()
    {
        if (tmp.text != "")
        {
            tmp.text = tmp.text.Remove(tmp.text.Length - 1);
        }
    }
    public void ItsZero()
    {
        tmp = fields[0];
    }
    public void ItsOne()
    {
        tmp = fields[1];
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

    public void EqualTo()
    {
        if (fields[0].text != "" && fields[1].text != "")
        {
            long zero = long.Parse(fields[0].text);
            long one = long.Parse(fields[1].text);
            if (one != 0)
            {
                long a = Kalan(zero, one);
                kalanText.text = a.ToString();
                bölümText.text = ((zero - a) / one).ToString();
            }
        }
    }
}
