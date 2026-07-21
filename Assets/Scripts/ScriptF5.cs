using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class ScriptF5 : MonoBehaviour
{
    public TMP_InputField[] fields;
    TMP_InputField tmp;
    string tmp2;
    public TextMeshProUGUI info;
    public TextMeshProUGUI super1,sub1,super2,sub2;
    public GameObject kesir1, kesir2;
    public TextMeshProUGUI bayagiInfo;
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
    public void Minus()
    {
        if (tmp.text == "")
        {
            tmp.text += "-";
        }
    }
    public void Button1()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
        {
            tmp.text += "1";
        }
    }
    public void Button2()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
        {
            tmp.text += "2";
        }
    }
    public void Button3()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
        {
            tmp.text += "3";
        }
    }
    public void Button4()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
        {
            tmp.text += "4";
        }
    }
    public void Button5()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
        {
            tmp.text += "5";
        }
    }
    public void Button6()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
        {
            tmp.text += "6";
        }
    }
    public void Button7()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
        {
            tmp.text += "7";
        }
    }
    public void Button8()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
        {
            tmp.text += "8";
        }
    }
    public void Button9()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
        {
            tmp.text += "9";
        }
    }
    public void Button0()
    {
        tmp2 = tmp.text;
        tmp2 = tmp2.Replace(",", "");
        tmp2 = tmp2.Replace("-", "");
        if (tmp.characterLimit > tmp2.Length)
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

    public void Result(int a, int b, int c)
    {
        int delta = (b * b) - (4 * c * a);
        int r11 = -b;
        int r22 = 2 * a;
        int k11 = (b * b * a) + (-b * b * 2 * a) + (4 * a * a * c);
        int k22 = 4 * a * a;
        int rr = ebobb(r11, r22);
        int kk = ebobb(k11,k22);
        if (delta < 0)
        {
            if (r22 / rr != 1 && k22 / kk != 1) bayagiInfo.text = "Denklemin reel kökü yoktur, kökler sanaldır.\n Parabol, x eksenini kesmez. \n Tepe noktası: (" + r11/rr + "/" + r22/rr + "," + k11/kk + "/" + k22/kk + ")";
            if (r22 / rr == 1 && k22 / kk == 1) bayagiInfo.text = "Denklemin reel kökü yoktur, kökler sanaldır.\n Parabol, x eksenini kesmez. \n Tepe noktası: (" + r11 / rr + "," + k11 / kk + ")";
            if (r22 / rr == 1 && k22 / kk != 1) bayagiInfo.text = "Denklemin reel kökü yoktur, kökler sanaldır.\n Parabol, x eksenini kesmez. \n Tepe noktası: (" + r11 / rr + "," + k11 / kk + "/" + k22 / kk + ")";
            if (r22 / rr != 1 && k22 / kk == 1) bayagiInfo.text = "Denklemin reel kökü yoktur, kökler sanaldır.\n Parabol, x eksenini kesmez. \n Tepe noktası: (" + r11 / rr + "/" + r22 / rr + "," + k11 / kk + ")";
            List<int> list = simplicateRoot(-delta);

            if (list[1] != 1)
            {
                int k = ebobbb(list[0], b, 2 * a);
                if (list[0] / k == 1)
                {
                    super1.text = -b / k + "-" + "i√" + list[1];
                    sub1.text = (2 * a / k).ToString();
                    super2.text = -b / k + "+" + "i√" + list[1];
                    sub2.text = (2 * a / k).ToString();
                }
                else
                {
                    super1.text = -b / k + "-" + list[0] / k + "i√" + list[1];
                    sub1.text = (2 * a / k).ToString();
                    super2.text = -b / k + "+" + list[0] / k + "i√" + list[1];
                    sub2.text = (2 * a / k).ToString();
                }
                if (2 * a / k == 1)
                {
                    kesir1.SetActive(false);
                    kesir2.SetActive(false);
                    sub1.text = "";
                    sub2.text = "";
                }
                else
                {
                    kesir1.SetActive(true);
                    kesir2.SetActive(true);
                }
            }
            if (list[1] == 1)
            {
                int k = ebobbb(list[0], b, 2 * a);
                if (list[0] / k == 1)
                {
                    super1.text = -b / k + "-" + "i";
                    sub1.text = (2 * a / k).ToString();
                    super2.text = -b / k + "+" + "i";
                    sub2.text = (2 * a / k).ToString();
                }
                else
                {
                    super1.text = -b / k + "-" + list[0] / k + "i";
                    sub1.text = (2 * a / k).ToString();
                    super2.text = -b / k + "+" + list[0] / k + "i";
                    sub2.text = (2 * a / k).ToString();
                }
                if (2 * a / k == 1)
                {
                    kesir1.SetActive(false);
                    kesir2.SetActive(false);
                    sub1.text = "";
                    sub2.text = "";
                }
                else
                {
                    kesir1.SetActive(true);
                    kesir2.SetActive(true);
                }
            }
        }
        if (delta == 0)
        {
            if (r22 / rr != 1 && k22 / kk != 1) bayagiInfo.text = "Denklemin bir adet reel kökü vardır. \n Çözüm kümesi bir elemanlıdır, kökler çakışıktır. \n Parabol, x eksenine teğettir. \n Tepe noktası: (" + r11 / rr + "/" + r22 / rr + "," + k11 / kk + "/" + k22 / kk + ")";
            if (r22 / rr == 1 && k22 / kk == 1) bayagiInfo.text = "Denklemin bir adet reel kökü vardır. \n Çözüm kümesi bir elemanlıdır, kökler çakışıktır. \n Parabol, x eksenine teğettir. \n Tepe noktası: (" + r11 / rr + "," + k11 / kk + ")";
            if (r22 / rr == 1 && k22 / kk != 1) bayagiInfo.text = "Denklemin bir adet reel kökü vardır. \n Çözüm kümesi bir elemanlıdır, kökler çakışıktır. \n Parabol, x eksenine teğettir. \n Tepe noktası: (" + r11 / rr + "," + k11 / kk + "/" + k22 / kk + ")";
            if (r22 / rr != 1 && k22 / kk == 1) bayagiInfo.text = "Denklemin bir adet reel kökü vardır. \n Çözüm kümesi bir elemanlıdır, kökler çakışıktır. \n Parabol, x eksenine teğettir. \n Tepe noktası: (" + r11 / rr + "/" + r22 / rr + "," + k11 / kk + ")";
            int j = ebobb(b, 2 * a);
            super1.text = (-b / j).ToString();
            sub1.text = (2*a/j).ToString();
            if (2 * a / j == 1)
            {
                kesir1.SetActive(false);
                kesir2.SetActive(false);
                sub1.text = "";
                sub2.text = "";
                super2.text = "";
            }
            else
            {
                kesir1.SetActive(true);
                kesir2.SetActive(false);
                sub2.text = "";
                super2.text = "";
            }
        }
        if (delta > 0)
        {
            if(r22/rr != 1 && k22/kk != 1)bayagiInfo.text = "Denklemin iki farklı reel kökü vardır. \n Parabol, x eksenini iki kez keser. \n Tepe noktası: (" + r11 / rr + "/" + r22 / rr + "," + k11 / kk + "/" + k22 / kk + ")";
            if (r22 / rr == 1 && k22 / kk == 1) bayagiInfo.text = "Denklemin iki farklı reel kökü vardır. \n Parabol, x eksenini iki kez keser. \n Tepe noktası: (" + r11 / rr + "," + k11 / kk + ")";
            if (r22 / rr != 1 && k22 / kk == 1) bayagiInfo.text = "Denklemin iki farklı reel kökü vardır. \n Parabol, x eksenini iki kez keser. \n Tepe noktası: (" + r11 / rr + "/" + r22 / rr + "," + k11 / kk + ")";
            if (r22 / rr == 1 && k22 / kk != 1) bayagiInfo.text = "Denklemin iki farklı reel kökü vardır. \n Parabol, x eksenini iki kez keser. \n Tepe noktası: (" + r11 / rr + "," + k11 / kk + "/" + k22 / kk + ")";
            List<int> list = simplicateRoot(delta);
            if (list[1] != 1)
            {
                int k = ebobbb(list[0], b, 2 * a); 
                if (list[0]/k == 1)
                {
                    super1.text = -b / k + "-" + "√" + list[1];
                    sub1.text = (2 * a / k).ToString();
                    super2.text = -b / k + "+" + "√" + list[1];
                    sub2.text = (2 * a / k).ToString();
                }
                else
                {
                    super1.text = -b / k + "-" + list[0] / k + "√" + list[1];
                    sub1.text = (2 * a / k).ToString();
                    super2.text = -b / k + "+" + list[0] / k + "√" + list[1];
                    sub2.text = (2 * a / k).ToString();
                }
                if (2 * a /k == 1)
                {
                    kesir1.SetActive(false);
                    kesir2.SetActive(false);
                    sub1.text = "";
                    sub2.text = "";
                } else
                {
                    kesir1.SetActive(true);
                    kesir2.SetActive(true);
                }
            }
            if (list[1] == 1)
            {
                int k1 = ebobb(Mathf.Abs(-list[0] - b), 2 * a);
                super1.text = ((-list[0] - b) / k1).ToString();
                sub1.text = (2 * a / k1).ToString();
                if (2*a/k1 == 1)
                {
                    kesir1.SetActive(false);
                    sub1.text = "";
                }
                else
                {
                    kesir1.SetActive(true);
                }
                int k2 = ebobb(Mathf.Abs(list[0] - b), 2 * a);
                super2.text = ((list[0] - b) / k2).ToString();
                sub2.text = (2 * a / k2).ToString();
                if (2 * a / k2 == 1)
                {
                    kesir2.SetActive(false);
                    sub2.text = "";
                }
                else
                {
                    kesir2.SetActive(true);
                }
            }
            
        }
    }

    public List<int> simplicateRoot(int root)
    {
        List<int> result = new List<int>();
        List<int> ints = components(root);
        List<int> sints = simplifiedComponents(root, components(root));
        int tam = 1;
        int other = 1;
        for (int i = 0; i < sints.Count; i++)
        {
            int j = howMuch(sints[i], ints);
            while (j >= 2)
            {
                tam *= sints[i];
                j -= 2;
            }
            if (j == 1)
            {
                other *= sints[i];
            }
        }
        result.Add(tam);
        if (other == 0)
        {
            other = 1;
        }
        result.Add(other);
        return result;
    }

    public int ebobb(int a,int b)
    {
        List<int> list = new List<int>();
        list.Add(Mathf.Abs(a));list.Add(Mathf.Abs(b));
        bool isHappening = true;
        for (int i = list.Max(); i >= 0; i--)
        {
            isHappening = true;
            foreach (var item in list)
            {
                if (item != 0)
                {
                    if (item % i != 0)
                    {
                        isHappening = false;
                    }
                }  
            }
            if (isHappening)
            {
                return i;
            }
        }
        return 1;
    }

    public int ebobbb(int a, int b, int c)
    {
        List<int> list = new List<int>();
        list.Add(a); list.Add(b);list.Add(c);
        int min = list.Min();
        bool isHappening = true;
        for (int i = min; i >= 2; i--)
        {
            isHappening = true;
            foreach (var item in list)
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

    public void EqualTo()
    {
        if (fields[0].text != "" && fields[1].text != "" && fields[2].text != "")
        {
            int a = Int32.Parse(fields[0].text);
            int b = Int32.Parse(fields[1].text);
            int c = Int32.Parse(fields[2].text);
            Result(a, b, c);
        }  
    }
}