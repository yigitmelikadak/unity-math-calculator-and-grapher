using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptE0 : MonoBehaviour
{
    [SerializeField]
    public static float deltaX, deltaY;
    float minX,maxX,minY,maxY;
    public LineRenderer lineRenderer;
    public GameObject prefab; 
    List<Vector3> vectors = new List<Vector3>();
    float dx, dy,cd;
    bool once;
    float sensivity = 1f;
    public static List<GameObject> formulas = new List<GameObject>();
    public static bool isEditing = false;
    public static bool uptodate = false;
    List<string> liness = new List<string>();
    Color32[] color = new Color32[10];

    private void OnEnable()
    {
        color[0] = RandomizeColor();
        color[1] = RandomizeColor();
        color[2] = RandomizeColor();
        color[3] = RandomizeColor();
        color[4] = RandomizeColor();
        color[5] = RandomizeColor();
        color[6] = RandomizeColor();
        color[7] = RandomizeColor();
        color[8] = RandomizeColor();
        color[9] = RandomizeColor();
    }
    private Color32 RandomizeColor()
    {
        Color32 color =  new Color32((byte)Random.Range(0, 200), (byte)Random.Range(0, 200), (byte)Random.Range(0, 200), 240);
        return color;
    }
    private void Update()
    {
        Move();
        if (deltaX != dx || deltaY != dy || !once || uptodate || cd != Camera.main.orthographicSize)
        {
            SetAxis();
            SetLines();
            GameObject[] gms = GameObject.FindGameObjectsWithTag("laser");
            foreach (var item in gms)
            {
                Destroy(item);
            }
            liness.Clear();
            GameObject[] o = GameObject.FindGameObjectsWithTag("prefab");
            foreach (var item in o)
            {
                string s = item.transform.Find("text").gameObject.GetComponent<TextMeshProUGUI>().text;
                s = s.Replace("y =", "");
                liness.Add(s);
            }
            int index = 0;
            float cameraOrto100 = Camera.main.orthographicSize / 100;
            foreach (var item in liness)
            {
                float b = 180 / Camera.main.orthographicSize;
                if (item != "")
                {
                    lineRenderer = Instantiate(prefab).GetComponent<LineRenderer>();
                    lineRenderer.material = new Material(Shader.Find("Legacy Shaders/Particles/Alpha Blended Premultiply"));
                    lineRenderer.SetWidth(cameraOrto100, cameraOrto100);
                    Gradient gradient = new Gradient();
                    gradient.SetKeys(
                        new GradientColorKey[] { new GradientColorKey(color[index], 0.0f), new GradientColorKey(color[index], 1.0f) },
                        new GradientAlphaKey[] { new GradientAlphaKey(240, 0.0f), new GradientAlphaKey(240, 1.0f) }
                    );
                    lineRenderer.colorGradient = gradient;
                    vectors.Clear();
                    Vector3 maxV = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
                    Vector3 minV = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
                    minX = minV.x * b + deltaX * b; maxX = maxV.x * b + deltaX * b;
                    minY = minV.y * b + deltaY * b; maxY = maxV.y * b + deltaY * b;
                    for (int i = (int)minX; i <= (int)maxX; i++)
                    {
                        float x = (float)(i - deltaX * b) / b;
                        float virtualX = (float)i / b;
                        float y = FunctionOfX(virtualX, item) - deltaY;
                        Vector3 cam = new Vector3(x, y, 0);
                        vectors.Add(cam);
                    }
                    for (int i = 0; i < vectors.Count; i++)
                    {
                        lineRenderer.positionCount++;
                        lineRenderer.SetPosition(i, vectors[i]);
                    }
                }
                index++;
            }
            //Kesisenler();
            dx = deltaX;
            dy = deltaY;
            once = true;
            uptodate = false;
            cd = Camera.main.orthographicSize;
        }
    }

    public LineRenderer xAxis;
    public LineRenderer yAxis;
    

    public void Move()
    {
        sensivity = Camera.main.orthographicSize / 30;
        if (Input.touchCount > 0)
        {
            //Kesisenler();
            Touch touch = Input.GetTouch(0);
            if (!IsThereAObject(touch))
            {
                float x = touch.deltaPosition.x * Time.deltaTime * sensivity;
                float y = touch.deltaPosition.y * Time.deltaTime * sensivity;
                deltaX -= x; deltaY -= y;
            }
        }
    }

    public void Decrease()
    {
        Camera.main.orthographicSize -= 2;
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, 2f, 30f);
    }
    public void Increase()
    {
        Camera.main.orthographicSize += 2;
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, 2f, 30f);
    }

    public void Home()
    {
        deltaX = 0; deltaY = 0;
    }
    public GameObject formula;
    public Transform parent;
    int indexF = 0;
    public static TextMeshProUGUI tmp;
    public void AddGraphics()
    {
        if (indexF < 5)
        {
            GameObject go = Instantiate(formula, parent);
            formulas.Add(go);
            indexF++;
        }  
    }

    [SerializeField] GraphicRaycaster m_Raycaster;
    PointerEventData m_PointerEventData;
    [SerializeField] EventSystem m_EventSystem;
    public bool IsThereAObject(Touch touch)
    {
        m_PointerEventData = new PointerEventData(m_EventSystem);
        m_PointerEventData.position = touch.position;
        List<RaycastResult> results = new List<RaycastResult>();
        m_Raycaster.Raycast(m_PointerEventData, results);
        if (results.Count > 0)
        {
            return true; 
        } 
        else 
        { 
            return false; 
        }
    }

    public float FunctionOfX(float imaginaryX,string f)
    {
        string j = ExpoToNormie(f); j = j.Replace(" ", ""); j = j.Replace("+", " "); j = j.Replace("-", " ");
        string[] hulu3 = j.Split(' ');
        List<string> hulu2 = new List<string>();
        foreach (var i in hulu3)
        {
            if (i != "" && i != " ")
            {
                hulu2.Add(i);
            }
        }
        string[] hulu = hulu2.ToArray();
        string k = ExpoToNormie(f); 
        float v = 0;
        List<float> floats = new List<float>();
       
        foreach (var i in hulu)
        {
            if (k != "" && i != "")
            {
                k = k.Replace(i, "");
            }
        }
        k = k.Replace(" ", "");
        if (k.Length != hulu.Length)
        {
            k = "+" + k;
        }
        foreach (var item in hulu)
        {
                
                string[] i3 = item.Split("x");
                List<string> a = new List<string>();
                foreach(var i2 in i3)
                {
                    if (i2 != "" && i2 != " ")
                    {
                        a.Add(i2);
                    }
                }
                string[] i = a.ToArray();
                
                if (i.Length == 2)
                {
                    floats.Add(float.Parse(i[0]) * Mathf.Pow(imaginaryX, float.Parse(i[1])));
                }
                if (i.Length == 1)
                {
                    floats.Add(float.Parse(i[0]));
                }
            
        }
        for (int i = 0; i < k.Length; i++)
        {
            if (k[i] == '+')
            {
                v += floats[i];
            }
            else if (k[i] == '-')
            {
                v -= floats[i];
            }
        }
        return v;
    }

    public string ExpoToNormie(string f)
    {
        string j = f;
        if (j != "")
        {
            j = j.Replace(ToSuperScript(1), "1"); j = j.Replace(ToSuperScript(2), "2"); j = j.Replace(ToSuperScript(3), "3");
            j = j.Replace(ToSuperScript(4), "4"); j = j.Replace(ToSuperScript(5), "5"); j = j.Replace(ToSuperScript(6), "6");
            j = j.Replace(ToSuperScript(7), "7"); j = j.Replace(ToSuperScript(8), "8"); j = j.Replace(ToSuperScript(9), "9");
            j = j.Replace(ToSuperScript(0), "0"); j = j.Replace("⁻", "-");
        }
        return j;
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

    public void TurnBack()
    {
        SceneManager.LoadScene("Main");
    }
    public LineRenderer lineRendererPrefabForLines;
    public GameObject numerosPrefab;
    public void SetLines()
    {
        float cameraOrto = Camera.main.orthographicSize;
        GameObject[] gms = GameObject.FindGameObjectsWithTag("aaa");
        foreach (var item in gms)
        {
            Destroy(item);
        }
        Vector3 maxV = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Vector3 minV = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        float b = 180 / cameraOrto;
        minX = minV.x; maxX = maxV.x; minY = minV.y; maxY = maxV.y;
        float cameraOrto33 = Camera.main.orthographicSize/25-deltaY;
        float cameraOrto34 = Camera.main.orthographicSize/25-deltaX;
        float cameraOrtotimes2 = Camera.main.orthographicSize * 2;
        for (int i = Mathf.RoundToInt(minX)+(int)deltaX; i <= maxX+(int)deltaX + 1; i++)
        {
            if (Camera.main.orthographicSize <= 15 || i % 5 == 0)
            {
                if (i != 0)
                {
                    Vector3 numeroVector;
                    if (xAxis.GetPosition(0).y > Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y && xAxis.GetPosition(0).y < Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y) numeroVector = new Vector3(i - deltaX, cameraOrto33, 0);
                    else numeroVector = new Vector3(i - deltaX, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height / 4, 0)).y, 0);
                    GameObject numeros = Instantiate(numerosPrefab, numeroVector, Quaternion.identity);
                    numeros.GetComponent<RectTransform>().sizeDelta = new Vector2(cameraOrtotimes2, cameraOrtotimes2);
                    numeros.GetComponentInChildren<TextMeshProUGUI>().fontSize = cameraOrto / 20;
                    numeros.GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();
                }
                LineRenderer rf = Instantiate(lineRendererPrefabForLines);
                rf.positionCount = 2;
                rf.SetPosition(0, new Vector3(i - deltaX, maxY, 0));
                rf.SetPosition(1, new Vector3(i - deltaX, minY, 0));
                rf.SetWidth(cameraOrto / 200, cameraOrto / 200);
            }
            
        }
        for (int i = Mathf.RoundToInt(minY) + (int)deltaY - 1; i <= maxY + (int)deltaY + 1; i++)
        {
            if (Camera.main.orthographicSize <= 15 || i % 5 == 0)
            {
                if (i != 0)
                {
                    Vector3 numeroVector;
                    if (yAxis.GetPosition(0).x > Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x && yAxis.GetPosition(0).x < Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x) numeroVector = new Vector3(cameraOrto34, i - deltaY, 0);
                    else numeroVector = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(6 * Screen.width / 7, 0, 0)).x, i - deltaY, 0);
                    GameObject numeros = Instantiate(numerosPrefab, numeroVector, Quaternion.identity);
                    numeros.GetComponent<RectTransform>().sizeDelta = new Vector2(cameraOrtotimes2, cameraOrtotimes2);
                    numeros.GetComponentInChildren<TextMeshProUGUI>().fontSize = cameraOrto / 20;
                    numeros.GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();
                }
                LineRenderer rf = Instantiate(lineRendererPrefabForLines);
                rf.positionCount = 2;
                rf.SetPosition(0, new Vector3(minX, i - deltaY, 0));
                rf.SetPosition(1, new Vector3(maxX, i - deltaY, 0));
                rf.SetWidth(cameraOrto / 200, cameraOrto / 200);
            }
            
        }
    }
    public void SetAxis()
    {
        yAxis.positionCount = 2;
        Vector3 y0 = new Vector3(-deltaX, -Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y, 0);
        Vector3 y1 = new Vector3(-deltaX, Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y, 0);
        yAxis.SetPosition(0, y0);
        yAxis.SetPosition(1, y1);
        xAxis.SetWidth(Camera.main.orthographicSize / 100, Camera.main.orthographicSize / 100);
        yAxis.SetWidth(Camera.main.orthographicSize / 100, Camera.main.orthographicSize / 100);
        xAxis.positionCount = 2;
        Vector3 x0 = new Vector3(-Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x, -deltaY);
        Vector3 x1 = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x, -deltaY);
        xAxis.SetPosition(0, x0);
        xAxis.SetPosition(1, x1);
    }
    public void Kesisenler()
    {
        GameObject[] yeter = GameObject.FindGameObjectsWithTag("laser");
        List<LineRenderer> list = new List<LineRenderer>();
        foreach (GameObject go in yeter) 
        {
            list.Add(go.GetComponent<LineRenderer>());
        }
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (j>i)
                {
                    IsThereASame(list[i], list[j]);
                }
            }
        }
    }
    public GameObject kesisPrefab;
    public GameObject canvas;
    public void IsThereASame(LineRenderer a, LineRenderer b)
    {
        Debug.Log("a");
        GameObject[] muq = GameObject.FindGameObjectsWithTag("point");
        foreach (var item in muq)
        {
            Destroy(item);
        }
        List<Vector3> aaa = new List<Vector3>();
        List<Vector3> bbb = new List<Vector3>();
        for (int i = 0;i < a.positionCount;i++)
        {
            aaa.Add(a.GetPosition(i));
            if (a.GetPosition(i).x % 1 == 0 && a.GetPosition(i).y % 1 == 0)
            {
                
            }
        }
        for (int i = 0; i < b.positionCount; i++)
        {
            bbb.Add(b.GetPosition(i));
            if (b.GetPosition(i).x % 1 == 0 && b.GetPosition(i).y % 1 == 0)
            {
                
            }
            
        }
        List<int> fark = new List<int>();
        fark.Add(aaa.Count);
        fark.Add(bbb.Count);
        for (int i = 0; i < fark.Min(); i++)
        {
            if (aaa[i] == bbb[i])
            {
                Vector3 aw = aaa[i];
                GameObject su = Instantiate(kesisPrefab,aw,Quaternion.identity,canvas.transform);
                su.GetComponentInChildren<TextMeshProUGUI>().text = "(" + (Mathf.Round(aw.x + deltaX)) + "," + (Mathf.Round(aw.y + deltaY)) + ")";
            }
        }
    }

    public void KokIsaretleme()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("prefab");
        foreach (GameObject obj in objects)
        {
           
        }
    }
}

