using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ScriptF2 : MonoBehaviour
{
    public TMP_InputField field;
    public TMP_InputField tmp;
    public TextMeshProUGUI showPrime;
    public TextMeshProUGUI PrimesComponent;
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
        if (tmp.text != "" && tmp.text.Substring(tmp.text.Length - 1) != "/")
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
            LambdaExpression dynamicformul = DynamicExpressionParser.ParseLambda(new ParameterExpression[] { }, null, formul);
            var comp = dynamicformul.Compile();
            var sonuc = comp.DynamicInvoke();
            if (float.Parse(sonuc.ToString()) % 1 == 0)
            {
                if (isPrime(float.Parse(sonuc.ToString())))
                {
                    showPrime.text = sonuc.ToString() + " asal sayýdýr.";
                    PrimesComponent.text = "";
                }
                else
                {
                    PrimesComponent.text = sonuc + "=";
                    showPrime.text = sonuc + " asal sayý deðildir.";
                    List<int> ints = components(float.Parse(sonuc.ToString()));
                    foreach (var item in ints)
                    {
                        Debug.Log("components" + item);
                    }
                    List<int> sints = simplifiedComponents(float.Parse(sonuc.ToString()), components(float.Parse(sonuc.ToString())));
                    foreach (var item in sints)
                    {
                        Debug.Log("smpcompo" + item);
                    }
                    foreach (var item in sints)
                    {
                        string l = item.ToString();
                        string al = ToSuperScript(howMuch(item, ints));
                        PrimesComponent.text += l + al + ".";
                    }
                    PrimesComponent.text = PrimesComponent.text.Remove(PrimesComponent.text.Length - 1);
                }
            }
            else
            {
                showPrime.text = sonuc.ToString() + " tam sayý deðildir.";
                PrimesComponent.text = "";
            }
        }
    }

    bool isPrime(float a)
    {
        for (int i = 2; i<a; i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    List<int> components(float a)
    {
        float number = a;
        List<int> total = new List<int>();
        for (int i = 2; i <= number; i++)
        {
            while (number % i == 0)
            {
                total.Add(i);
                number = number / i;
            }
        }
        return total;
    }

    List<int> simplifiedComponents(float a, List<int> b)
    {
        float number = a;
        List<int> total = new List<int>();
        foreach (int i in b)
        {
            if (!total.Contains(i))
            {
                total.Add(i);
            }
        }
        return total;
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

    public string ToSuperScript(int number)
    {
        if (number == 0 ||
            number == 1)
            return "";

        const string SuperscriptDigits =
            "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

        string Superscript = "";

        if (number < 0)
        {
            //Adds superscript minus
            Superscript = ((char)0x207B).ToString();
            number *= -1;
        }


        Superscript += new string(number.ToString()
                                        .Select(x => SuperscriptDigits[x - '0'])
                                        .ToArray()
                                  );

        return Superscript;
    }

    public int howMuch(int a, List<int> b)
    {
        int count = 0;
        foreach (int l in b) 
        {
            if (l == a)
            {
                count++;
            } 
        }
        return count;
    }
}
