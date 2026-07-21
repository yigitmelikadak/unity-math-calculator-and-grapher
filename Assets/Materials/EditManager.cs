using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EditManager : MonoBehaviour
{
    public GameObject check, edit, delete, add,numbers;
    public GameObject silPrefab, eklePrefab;
    public GameObject numpadPrefab;
    public GameObject canvas;
    public TMP_InputField tmp2;
    public int stage;
    public GameObject one, two, three, four, five, six, seven, eight, nine, zero, minus, point,onayla,sil;
    float a, n;
    public void OnEnable()
    {
        stage = 0;
        canvas = GameObject.FindGameObjectWithTag("canvas");
        delete = Instantiate(silPrefab, canvas.transform);
        delete.GetComponent<Button>().onClick.AddListener(delegate { Delete(); });
        delete.SetActive( false );
        add = Instantiate(eklePrefab,canvas.transform);
        add.GetComponent<Button>().onClick.AddListener(delegate {  Add(); });
        add.SetActive( false );
        numbers = Instantiate(numpadPrefab, canvas.transform);
        tmp2 = numbers.gameObject.GetComponentInChildren<TMP_InputField>();
        one = numbers.transform.Find("1").gameObject;
        two = numbers.transform.Find("2").gameObject;
        three = numbers.transform.Find("3").gameObject;
        four = numbers.transform.Find("4").gameObject;
        five = numbers.transform.Find("5").gameObject;
        six = numbers.transform.Find("6").gameObject;
        seven = numbers.transform.Find("7").gameObject;
        eight = numbers.transform.Find("8").gameObject;
        nine = numbers.transform.Find("9").gameObject;
        zero = numbers.transform.Find("0").gameObject;
        minus = numbers.transform.Find("minus").gameObject;
        point = numbers.transform.Find("point").gameObject;
        onayla = numbers.transform.Find("equal").gameObject;
        sil = numbers.transform.Find("sil").gameObject;
        one.GetComponent<Button>().onClick.AddListener(delegate { One(); }) ;
        two.GetComponent<Button>().onClick.AddListener(delegate { Two(); });
        three.GetComponent<Button>().onClick.AddListener(delegate { Three(); });
        four.GetComponent<Button>().onClick.AddListener(delegate { Four(); });
        five.GetComponent<Button>().onClick.AddListener(delegate { Five(); });
        six.GetComponent<Button>().onClick.AddListener(delegate { Six(); });
        seven.GetComponent<Button>().onClick.AddListener(delegate { Seven(); });
        eight.GetComponent<Button>().onClick.AddListener(delegate { Eight(); });
        nine.GetComponent<Button>().onClick.AddListener(delegate { Nine(); });
        zero.GetComponent<Button>().onClick.AddListener(delegate { Zero(); });
        minus.GetComponent<Button>().onClick.AddListener(delegate { Minus(); });
        point.GetComponent<Button>().onClick.AddListener(delegate { Point(); });
        onayla.GetComponent<Button>().onClick.AddListener(delegate { Onay(); });
        sil.GetComponent<Button>().onClick.AddListener(delegate { Sil(); });
        numbers.SetActive(false);
    }
    public void Edit()
    {
        if (!ScriptE0.isEditing)
        {
            ScriptE0.tmp = this.gameObject.GetComponent<TextMeshProUGUI>();
            edit.SetActive(false);
            check.SetActive(true);
            delete.SetActive(true);
            add.SetActive(true);
            numbers.SetActive(false);
            ScriptE0.isEditing = true;
        }
    }
    public void Check()
    {
        if (stage == 2)
        {
            stage = 0;
            DeliDahiSanati();
        }
        edit.SetActive(true);
        check.SetActive(false);
        delete.SetActive(false);
        add.SetActive(false);
        numbers.SetActive(false);
        ScriptE0.isEditing = false;
    }
    public void Delete()
    {
        ScriptE0.tmp = this.gameObject.GetComponent<TextMeshProUGUI>();
        if (ScriptE0.tmp.text != "y =")
        {
            ScriptE0.tmp.text = ScriptE0.tmp.text.Remove(ScriptE0.tmp.text.Length - 1);
            while (ScriptE0.tmp.text[ScriptE0.tmp.text.Length - 1].ToString() != " " && ScriptE0.tmp.text[ScriptE0.tmp.text.Length - 1].ToString() != "=")
            {
                ScriptE0.tmp.text = ScriptE0.tmp.text.Remove(ScriptE0.tmp.text.Length - 1);
            }
            if (ScriptE0.tmp.text[ScriptE0.tmp.text.Length - 2].ToString() == "+"||
                ScriptE0.tmp.text[ScriptE0.tmp.text.Length - 2].ToString() == "-"
                )
            {
                ScriptE0.tmp.text = ScriptE0.tmp.text.Remove(ScriptE0.tmp.text.Length - 1);
                ScriptE0.tmp.text = ScriptE0.tmp.text.Remove(ScriptE0.tmp.text.Length - 1);
            }
            ScriptE0.uptodate = true;
        }
        else
        {
            Destroy(delete);
            Destroy(add);
            Destroy(numbers);
            Destroy(this.transform.parent.gameObject);
            ScriptE0.isEditing = false;
            ScriptE0.uptodate = true;
        }
    }
    public void Add()
    {
        ScriptE0.tmp = this.gameObject.GetComponent<TextMeshProUGUI>();
        add.SetActive(false);
        delete.SetActive(false);
        check.SetActive(false);
        numbers.SetActive(true);
        stage = 1;
        tmp2.GetComponent<TMP_InputField>().placeholder.GetComponent<TextMeshProUGUI>().text = "a";
        tmp2.characterLimit = 2;
    }
    public void One()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "1";
        }  
    }
    public void Two()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "2";
        }
    }
    public void Three()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "3";
        }
    }
    public void Four()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "4";
        }
    }
    public void Five()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "5";
        }
    }
    public void Six()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "6";
        }
    }
    public void Seven()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "7";
        }
    }
    public void Eight()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "8";
        }
    }
    public void Nine()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "9";
        }
    }
    public void Zero()
    {
        string q = tmp2.text; q = q.Replace(".", ""); q = q.Replace("-", "");
        if (tmp2.characterLimit > q.Length)
        {
            tmp2.text += "0";
        }
    }
    public void Minus()
    {
        if (tmp2.text == "" && stage != 2)
        {
            tmp2.text += "-";
        }
    }
    public void Point()
    {
        if(tmp2.text != "" && tmp2.text != "-" && stage != 2)
        {
            tmp2.text += ".";
        }
    }
    public void Onay()
    {
        if (stage == 2 && tmp2.text != "")
        {
            n = float.Parse(tmp2.text);
            tmp2.text = "";
            Check();
        }
        if (stage == 1 && tmp2.text != "")
        {
            stage = 2;
            tmp2.GetComponent<TMP_InputField>().placeholder.GetComponent<TextMeshProUGUI>().text = "n";
            a = float.Parse(tmp2.text, CultureInfo.InvariantCulture.NumberFormat);
            tmp2.text = "";
            tmp2.characterLimit = 1;
        }
    }
    public void Sil()
    {
        if (tmp2.text != "")
        {
            tmp2.text = tmp2.text.Remove(tmp2.text.Length - 1);
        }
    }
    public void DeliDahiSanati()
    {
        string total;
        if (n > 0)
        {
            if (a != 0)
            {
                if (ScriptE0.tmp.text == "y =")
                {
                    string nn = ToSuperScript((int)n);
                    total = a + "x" + nn + " ";
                    ScriptE0.tmp.text += total;
                }
                else
                {
                    if (a>0)
                    {
                        string nn = ToSuperScript((int)n);
                        total = "+ "+a + "x" + nn + " ";
                        ScriptE0.tmp.text += total;
                    }
                    else
                    {
                        string nn = ToSuperScript((int)n);
                        total = "- " + -a + "x" + nn + " ";
                        ScriptE0.tmp.text += total;
                    }
                }
            }
        }
        if (n == 0)
        {
            if (a != 0)
            {
                if (ScriptE0.tmp.text == "y =")
                {
                    total = a + " ";
                    ScriptE0.tmp.text += total;
                }
                else
                {
                    if (a>0)
                    {
                        total = "+ "+a + " ";
                        ScriptE0.tmp.text += total;
                    }
                    else
                    {
                        total = "- " + -a + " ";
                        ScriptE0.tmp.text += total;
                    }
                }
            }
        }
        if(n < 0)
        {
            if (a != 0)
            {
                if (ScriptE0.tmp.text == "y =")
                {
                    string nn = ToSuperScript((int)-n);
                    total = a + "x⁻" + nn + " ";
                    ScriptE0.tmp.text += total;
                }
                else
                {
                    if (a>0)
                    {
                        string nn = ToSuperScript((int)-n);
                        total = "+ "+a + "x⁻" + nn + " ";
                        ScriptE0.tmp.text += total;
                    }
                    else
                    {
                        string nn = ToSuperScript((int)-n);
                        total = "- " + -a + "x⁻" + nn + " ";
                        ScriptE0.tmp.text += total;
                    }
                } 
            }
        } 
        ScriptE0.uptodate = true;
    }
    public string ToSuperScript(int number)
    {
        if (number == 0) return "⁰";
        if (number == 1) return "¹";
           

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
}
