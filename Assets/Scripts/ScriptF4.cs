using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections.Generic;
using System;
using System.Linq;

public class ScriptF4 : MonoBehaviour
{
    public TMP_InputField[] fields;
    TMP_InputField tmp;
    public TextMeshProUGUI sonuc0,sonuc1;
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

    public void sadelestirme()
    {
        if (fields[0].text != "" && fields[1].text != "")
        {
            List<long> list = new List<long>();
            list.Add(long.Parse(fields[0].text));
            list.Add(long.Parse(fields[1].text));
            long a = Ebob(list.Min(), list);
            long b = list[0] / a;
            long c = list[1] / a;
            sonuc0.text = b.ToString();
            sonuc1.text = c.ToString();
        }
    }

    public long Ebob(long min, List<long> a)
    {
        bool isHappening = true;
        for (long i = min; i >= 2; i--)
        {
            isHappening = true;
            foreach (var item in a)
            {
                if (item % i != 0)
                {
                    isHappening = false;
                }
            }
            if (isHappening)
            {
                return i;
            }
        }
        return 1;
    }
}
