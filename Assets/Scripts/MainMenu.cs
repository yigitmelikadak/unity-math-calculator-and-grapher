using TMPro;
using UnityEngine;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField field;
    public TMP_InputField tmp;
    private void Start()
    {
        tmp = field.GetComponent<TMP_InputField>();
    }
    public void ButtonC()
    {
        tmp.text = "";
    }
    public void Button1()
    {
        tmp.text += "1";
    }
    public void Button2()
    {
        tmp.text += "2";
    }
    public void Button3()
    {
        tmp.text += "3";
    }
    public void Button4()
    {
        tmp.text += "4";
    }
    public void Button5()
    {
        tmp.text += "5";
    }
    public void Button6()
    {
        tmp.text += "6";
    }
    public void Button7()
    {
        tmp.text += "7";
    }
    public void Button8()
    {
        tmp.text += "8";
    }
    public void Button9()
    {
        tmp.text += "9";
    }
    public void Button0()
    {
        if (tmp.text != "" && tmp.text.Substring(tmp.text.Length -1) != "/")
        {
            tmp.text += "0";
        }

        if (tmp.text == "")
        {
            tmp.text += "0";
        }
    }
    public void ButtonMultiple()
    {
        string a = tmp.text;
        if (tmp.text != ""
            && a.Substring(tmp.text.Length - 1) != "x"
            && a.Substring(tmp.text.Length - 1) != "/"
            && a.Substring(tmp.text.Length - 1) != "-"
            && a.Substring(tmp.text.Length - 1) != "+"
            && a.Substring(tmp.text.Length - 1) != ",")
        {
            tmp.text += "x";
        }
    }
    public void ButtonDivision()
    {
        string a = tmp.text;
        if (tmp.text != ""
            && a.Substring(tmp.text.Length - 1) != "x"
            && a.Substring(tmp.text.Length - 1) != "/"
            && a.Substring(tmp.text.Length - 1) != "-"
            && a.Substring(tmp.text.Length - 1) != ","
            && a.Substring(tmp.text.Length - 1) != "+")
        {
            tmp.text += "/";
        }
    }
    public void ButtonMinus()
    {
        string a = tmp.text;
        if (tmp.text != "" 
            && a.Substring(tmp.text.Length - 1) != "x" 
            && a.Substring(tmp.text.Length - 1) != "/" 
            && a.Substring(tmp.text.Length - 1) != "-"
            && a.Substring(tmp.text.Length - 1) != ","
            && a.Substring(tmp.text.Length - 1) != "+")
        {
            tmp.text += "-";
        }
    }
    public void ButtonAdd()
    {
        string a = tmp.text;
        if (tmp.text != ""
            && a.Substring(tmp.text.Length - 1) != "x"
            && a.Substring(tmp.text.Length - 1) != "/"
            && a.Substring(tmp.text.Length - 1) != "-"
            && a.Substring(tmp.text.Length - 1) != ","
            && a.Substring(tmp.text.Length - 1) != "+")
        {
            tmp.text += "+";
        }
    }

    public void ButtonDelete()
    {
        if (tmp.text != "")
        {
            tmp.text = tmp.text.Remove(tmp.text.Length - 1);
        }
    }

    public void ButtonComma()
    {
        string a = tmp.text;
        if (tmp.text != ""
            && a.Substring(tmp.text.Length - 1) != "x"
            && a.Substring(tmp.text.Length - 1) != "/"
            && a.Substring(tmp.text.Length - 1) != "-"
            && a.Substring(tmp.text.Length - 1) != ","
            && a.Substring(tmp.text.Length - 1) != "+")
        {
            tmp.text += ",";
        }
    }
    List<string> list = new List<string>();
    string formul;
    public void Calculate()
    {
        if (tmp.text != "")
        {
            list.Clear();
            formul = "";
            if (tmp.text.StartsWith("-"))
            {
                tmp.text = "0" + tmp.text;
            }
            string a = tmp.text;
            a = a.Replace("x", " ");
            a = a.Replace("/", " ");
            a = a.Replace("+", " ");
            a = a.Replace("-", " ");
            string[] sas = a.Split(" ");
            string b = tmp.text;
            foreach (string item in sas)
            {
                b = b.Replace(item, " ");
            }
            foreach (string item in sas)
            {
                string j = item;
                if (j.Substring(j.Length - 1) == ",")
                {
                    j = j.Replace(",", "");
                }
                string i = j + "f";
                list.Add(i);
            }
            string[] bas = b.Split(" ");
            List<string> length = new List<string>();
            foreach (var item in bas)
            {
                if (item != " " && item != "")
                {
                    length.Add(item);
                }
            }
            for (int i = 0; i < length.Count; i++)
            {
                formul += list[i];
                formul += length[i];
            }
            formul += list[length.Count];
            formul = formul.Replace("x", "*");
            formul = formul.Replace(",", ".");
            Debug.Log(formul);
            LambdaExpression dynamicformul = DynamicExpressionParser.ParseLambda(new ParameterExpression[] { }, null, formul);
            var comp = dynamicformul.Compile();
            var sonuc = comp.DynamicInvoke();
            tmp.text = sonuc.ToString();
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
}
