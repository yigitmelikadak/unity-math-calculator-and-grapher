using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ScriptE1 : MonoBehaviour
{
    GameObject[] points;
    GameObject one, two, three, four, five, six, seven, eight, nine;
    int b = 0;
    public LineRenderer shape;
    public GameObject point;
    public static bool anyupdates;
    public GameObject llength;
    private void Update()
    {
        if (anyupdates)
        {
            GenerateShape();
            anyupdates = false;
        }
        if (ScrollManager.i == 3 && b != 3)
        {
            shape.positionCount = 0;
            GameObject[] a = GameObject.FindGameObjectsWithTag("kose");
            foreach (GameObject go in a) { Destroy(go); }
            points = new GameObject[3];
            one = Instantiate(point, new Vector3(-1, 0, 0), Quaternion.identity);
            two = Instantiate(point, new Vector3(1, 0, 0), Quaternion.identity);
            three = Instantiate(point, new Vector3(0, 2, 2), Quaternion.identity);
            points[0] = one;
            points[1] = two;
            points[2] = three;
            GenerateShape();
            b = ScrollManager.i;
        }
        if (ScrollManager.i == 4 && b!= 4)
        {
            shape.positionCount = 0;
            GameObject[] a = GameObject.FindGameObjectsWithTag("kose");
            foreach (GameObject go in a) { Destroy(go); }
            points = new GameObject[4];
            one = Instantiate(point, new Vector3(-1, 2, 2), Quaternion.identity);
            two = Instantiate(point, new Vector3(1, 2, 2), Quaternion.identity);
            three = Instantiate(point, new Vector3(1, 0, 0), Quaternion.identity);
            four = Instantiate(point, new Vector3(-1, 0, 0), Quaternion.identity);
            points[0] = one;
            points[1] = two;
            points[2] = three;
            points[3] = four;
            GenerateShape();
            b = ScrollManager.i;
        }
        if (ScrollManager.i == 5 && b != 5)
        {
            shape.positionCount = 0;
            GameObject[] a = GameObject.FindGameObjectsWithTag("kose");
            foreach (GameObject go in a) { Destroy(go); }
            points = new GameObject[5];
            one = Instantiate(point, new Vector3(-1, 0, 0), Quaternion.identity);
            two = Instantiate(point, new Vector3(-2, 2, 2), Quaternion.identity);
            three = Instantiate(point, new Vector3(0, 4, 4), Quaternion.identity);
            four = Instantiate(point, new Vector3(2, 2, 2), Quaternion.identity);
            five = Instantiate(point, new Vector3(1, 0, 0), Quaternion.identity);
            points[0] = one;
            points[1] = two;
            points[2] = three;
            points[3] = four;
            points[4] = five;
            GenerateShape();
            b = ScrollManager.i;
        }
        if (ScrollManager.i == 6 && b != 6)
        {
            shape.positionCount = 0;
            GameObject[] a = GameObject.FindGameObjectsWithTag("kose");
            foreach (GameObject go in a) { Destroy(go); }
            points = new GameObject[6];
            one = Instantiate(point, new Vector3(-1, 0, 0), Quaternion.identity);
            two = Instantiate(point, new Vector3(-2, 2, 2), Quaternion.identity);
            three = Instantiate(point, new Vector3(-1, 4, 4), Quaternion.identity);
            four = Instantiate(point, new Vector3(1, 4, 4), Quaternion.identity);
            five = Instantiate(point, new Vector3(2, 2, 2), Quaternion.identity);
            six = Instantiate(point, new Vector3(1, 0, 0), Quaternion.identity);
            points[0] = one;
            points[1] = two;
            points[2] = three;
            points[3] = four;
            points[4] = five;
            points[5] = six;
            GenerateShape();
            b = ScrollManager.i;
        }
        if (ScrollManager.i == 7 && b != 7)
        {
            shape.positionCount = 0;
            GameObject[] a = GameObject.FindGameObjectsWithTag("kose");
            foreach (GameObject go in a) { Destroy(go); }
            points = new GameObject[7];
            one = Instantiate(point, new Vector3(-1, 0, 0), Quaternion.identity);
            two = Instantiate(point, new Vector3(-2, 1, 1), Quaternion.identity);
            three = Instantiate(point, new Vector3(-2, 3, 3), Quaternion.identity);
            four = Instantiate(point, new Vector3(0, 4, 4), Quaternion.identity);
            five = Instantiate(point, new Vector3(2, 3, 3), Quaternion.identity);
            six = Instantiate(point, new Vector3(2, 1, 1), Quaternion.identity);
            seven = Instantiate(point, new Vector3(1, 0, 0), Quaternion.identity);
            points[0] = one;
            points[1] = two;
            points[2] = three;
            points[3] = four;
            points[4] = five;
            points[5] = six;
            points[6] = seven;
            GenerateShape();
            b = ScrollManager.i;
        }
        if (ScrollManager.i == 8 && b != 8)
        {
            shape.positionCount = 0;
            GameObject[] a = GameObject.FindGameObjectsWithTag("kose");
            foreach (GameObject go in a) { Destroy(go); }
            points = new GameObject[8];
            one = Instantiate(point, new Vector3(-1, 0, 0), Quaternion.identity);
            two = Instantiate(point, new Vector3(-2, 1, 1), Quaternion.identity);
            three = Instantiate(point, new Vector3(-2, 3, 3), Quaternion.identity);
            four = Instantiate(point, new Vector3(-1, 4, 4), Quaternion.identity);
            five = Instantiate(point, new Vector3(1, 4, 4), Quaternion.identity);
            six = Instantiate(point, new Vector3(2, 3, 3), Quaternion.identity);
            seven = Instantiate(point, new Vector3(2, 1, 1), Quaternion.identity);
            eight = Instantiate(point, new Vector3(1, 0, 0), Quaternion.identity);
            points[0] = one;
            points[1] = two;
            points[2] = three;
            points[3] = four;
            points[4] = five;
            points[5] = six;
            points[6] = seven;
            points[7] = eight;
            GenerateShape();
            b = ScrollManager.i;
        }
        if (ScrollManager.i == 9 && b != 9)
        {
            shape.positionCount = 0;
            GameObject[] a = GameObject.FindGameObjectsWithTag("kose");
            foreach (GameObject go in a) { Destroy(go); }
            points = new GameObject[9];
            one = Instantiate(point, new Vector3(-1, 0, 0), Quaternion.identity);
            two = Instantiate(point, new Vector3(-2, 1, 1), Quaternion.identity);
            three = Instantiate(point, new Vector3(-2, 3, 3), Quaternion.identity);
            four = Instantiate(point, new Vector3(-1, 4, 4), Quaternion.identity);
            five = Instantiate(point, new Vector3(0, 3, 3), Quaternion.identity);
            six = Instantiate(point, new Vector3(1, 4, 4), Quaternion.identity);
            seven = Instantiate(point, new Vector3(2, 3, 3), Quaternion.identity);
            eight = Instantiate(point, new Vector3(2, 1, 1), Quaternion.identity);
            nine = Instantiate(point, new Vector3(1, 0, 0), Quaternion.identity);
            points[0] = one;
            points[1] = two;
            points[2] = three;
            points[3] = four;
            points[4] = five;
            points[5] = six;
            points[6] = seven;
            points[7] = eight;
            points[8] = nine;
            GenerateShape();
            b = ScrollManager.i;
        }
    }

    void GenerateShape()
    {
        GameObject[] bb = GameObject.FindGameObjectsWithTag("nine");
        foreach (GameObject bb2 in bb) { Destroy(bb2); }
        if (ScrollManager.isActive)
        {
            shape.positionCount = ScrollManager.i + 1;
            for (int i = 0; i < ScrollManager.i; i++)
            {
                shape.SetPosition(i, points[i].transform.position);
                if (i != ScrollManager.i - 1)
                {
                    Vector3 total = (points[i].transform.position + points[i + 1].transform.position) / 2;
                    Vector3 length = points[i + 1].transform.position - points[i].transform.position;
                    GameObject um = Instantiate(llength, total, Quaternion.identity);
                    List<int> aw1 = simplicateRoot(CalculatingLength(length));
                    string ow1 = "";
                    if (aw1[1] == 1){ow1 = aw1[0].ToString();}
                    if (aw1[1] != 1 && aw1[0] != 1){ ow1 = aw1[0] + "√" + aw1[1];}
                    if (aw1[1] != 1 && aw1[0] == 1){ ow1 = "√" + aw1[1]; }
                    um.GetComponentInChildren<TextMeshProUGUI>().text = ow1;
                } 
            }
            shape.SetPosition(ScrollManager.i, points[0].transform.position);
            Vector3 totalL = (points[ScrollManager.i-1].transform.position + points[0].transform.position) / 2;
            Vector3 lengthL = points[ScrollManager.i-1].transform.position - points[0].transform.position;
            GameObject umL = Instantiate(llength, totalL, Quaternion.identity);
            List<int> aw = simplicateRoot(CalculatingLength(lengthL));
            string ow = "";
            if (aw[1] == 1) { ow = aw[0].ToString(); }
            if (aw[1] != 1 && aw[0] != 1) { ow = aw[0] + "√" + aw[1]; }
            if (aw[1] != 1 && aw[0] == 1) { ow = "√" + aw[1]; }
            umL.GetComponentInChildren<TextMeshProUGUI>().text = ow;
        }
        else
        {
            shape.positionCount = ScrollManager.i + 1;
            for (int i = 0; i < ScrollManager.i; i++)
            {
                shape.SetPosition(i, points[i].transform.position);
            }
            shape.SetPosition(ScrollManager.i, points[0].transform.position);
        }
    }
    int CalculatingLength(Vector3 length)
    {
        int x = Mathf.Abs((int)length.x);
        int y = Mathf.Abs((int)length.y);
        int z = x * x + y * y;
        return z;
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

    public void TurnBack()
    {
        SceneManager.LoadScene("Main");
    }
}
