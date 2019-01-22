using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour {

     int Points = 0;
    public int BronzePoints = 10;
    public int SilverPoints = 30;
    public int GoldPoints = 50;


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

        if (Points > BronzePoints) GetComponent<Text>().color = Color.grey;

        if (Points > SilverPoints) GetComponent<Text>().color = Color.blue;
         if (Points > GoldPoints) GetComponent<Text>().color = Color.yellow;


       // else GetComponent<Text>().color = Color.yellow;


    }

}
