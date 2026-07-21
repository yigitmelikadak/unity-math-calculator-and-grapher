using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptF0 : MonoBehaviour
{
    public TMP_InputField[] field;
    public TMP_InputField tmp;
    public GameObject panelF, panelE;
    public TextMeshProUGUI sonuc;
    private void Start()
    {
        tmp = field[0].GetComponent<TMP_InputField>();
    }
    public void ButtonC()
    {
        tmp.text = "";
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
            if (tmp.text != "" && tmp.text.Substring(tmp.text.Length - 1) != "/")
            {
                tmp.text += "0";
            }

            if (tmp.text == "")
            {
                tmp.text += "0";
            }
        } 
    }
    public void ChangeTMP0()
    {
        tmp = field[0];
    }
    public void ChangeTMP1()
    {
        tmp = field[1];
    }
    public void ChangeTMP2()
    {
        tmp = field[2];
    }
    public void ChangeTMP3()
    {
        tmp = field[3];
    }
    public void ChangeTMP4()
    {
        tmp = field[4];
    }
    public void ChangeTMP5()
    {
        tmp = field[5];
    }
    public void ChangeTMP6()
    {
        tmp = field[6];
    }
    public void ChangeTMP7()
    {
        tmp = field[7];
    }
    public void ChangeTMP8()
    {
        tmp = field[8];
    }
    public void ChangeTMP9()
    {
        tmp = field[9];
    }
    public void ChangeTMP10()
    {
        tmp = field[10];
    }
    public void ChangeTMP11()
    {
        tmp = field[11];
    }
    public void ButtonDelete()
    {
        if (tmp.text != "")
        {
            tmp.text = tmp.text.Remove(tmp.text.Length - 1);
        }
    }

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

    public void EbobEqual()
    {
        List<int> list = new List<int>();
        foreach (var item in field)
        {
            if (item.GetComponent<TMP_InputField>().text != "")
            {
                int a = Int32.Parse(item.text);
                list.Add(a);
            }
        }
        if (list.Count > 0)
        {
            int min = list.Min();
            int ebobb = Ebob(min, list);
            sonuc.text = ebobb + "=";
            List<int> ints = components(float.Parse(ebobb.ToString()));
            List<int> sints = simplifiedComponents(float.Parse(ebobb.ToString()), components(float.Parse(ebobb.ToString())));
            foreach (var item in sints)
            {
                string l = item.ToString();
                string al = ToSuperScript(howMuch(item, ints));
                sonuc.text += l + al + ".";
            }
            sonuc.text = sonuc.text.Remove(sonuc.text.Length - 1);
        }
    }
    public void EkokEqual()
    {
        List<int> list = new List<int>();
        foreach (var item in field)
        {
            if (item.GetComponent<TMP_InputField>().text != "")
            {
                int a = Int32.Parse(item.text);
                list.Add(a);
            }
        }
        long ekokk = Ekok(list);
        sonuc.text = ekokk + "=";
        List<int> ints = components(float.Parse(ekokk.ToString()));
        List<int> sints = simplifiedComponents(float.Parse(ekokk.ToString()), components(float.Parse(ekokk.ToString())));
        foreach (var item in sints)
        {
            string l = item.ToString();
            string al = ToSuperScript(howMuch(item, ints));
            sonuc.text += l + al + ".";
        }
        sonuc.text = sonuc.text.Remove(sonuc.text.Length - 1);
    }
    public int Ebob(int min, List<int> a)
    {
        bool isHappening = true;
        for (int i = min; i >= 2; i--)
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
    public long Ekok(List<int> a)
    {
        List<int> bolenler = new List<int>();
        List<int> list = a;
        long sonuc = 1;
        if (!IsAllOne(list)) 
        {
            int max = list.Max();
            for (int i = 2; i <= max; i++)
            {
                for(int l = 0; l < list.Count; l++)
                {
                    if (list[l] % i == 0)
                    {
                        while (list[l] % i == 0)
                        {
                            bolenler.Add(i);
                            for (int k = 0; k < list.Count(); k++)
                            {
                                if (list[k] % i == 0)
                                {
                                    list[k] = list[k] / i;
                                }
                            }
                        }
                    }
                }
            }
        }
        foreach (var item in bolenler)
        {
            sonuc *= item;
        }
        return sonuc;
    }

    public bool IsAllOne(List<int> a)
    {
        foreach (var item in a)
        {
            if (item != 1)
            {
                return false;
            }
        }
        return true;
    }

    bool isPrime(float a)
    {
        for (int i = 2; i < a; i++)
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
