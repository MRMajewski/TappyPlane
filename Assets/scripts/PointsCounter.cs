using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour {

     int Points = 0;

    void Start()
    {
        SavePoints();
        RefreshText();
    
    }

    public void IncrementPoints()
    {
        Points++;

        SavePoints();
        RefreshText();
   
    }

    public void SavePoints()
    {
        PlayerPrefs.SetInt("currentPoints", Points);
    }


    void RefreshText()
    {
        GetComponent<Text>().text = Points + " points";
    }

}
