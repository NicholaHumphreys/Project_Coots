using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CootsPoints : MonoBehaviour
{
    public TMP_Text pointsdisplay;

    private int Points;

    // Start is called before the first frame update
    void Start()
    {
        Points = 0;
        pointsdisplay.text = Points.ToString();
    }

    void Update()
    {
        //print(Points);
    }

    public void AddPoints(int amount)
    {
        Points = Points + amount;
        pointsdisplay.text = Points.ToString();
    }
}
