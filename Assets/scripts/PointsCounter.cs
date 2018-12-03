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

        if (Points < 2) GetComponent<Text>().color = Color.black;

        else if (Points < 6) GetComponent<Text>().color = Color.blue;

        else GetComponent<Text>().color = Color.yellow;


    }

}
