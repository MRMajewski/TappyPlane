using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour {

     int Points = 0;

    void Start()
    {
        RefreshText();
    }

    public void IncrementPoints()
    {
        Points++;
        RefreshText();
    }



    void RefreshText()
    {
        GetComponent<Text>().text = Points + " points";
    }

}
