using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

[System.Serializable]
public class Medal
{
    public Sprite Image;
    public int MinimumPoints;
}



public class GameOverScore : MonoBehaviour {

    public Text Score;
    public Image Medal;
    public GameObject Record;

    public Medal[] Medals;



	// Use this for initialization
	void Start () {
        RefreshPoints();
        RefreshMedal();
        RefreshRecord();

    }

    int GetCurrentPoints()
    {
       return PlayerPrefs.GetInt("currentPoints", 0);
    }

    void RefreshPoints()
    {
        var points = GetCurrentPoints();
        Score.text = points + " points!";
    }

    void RefreshMedal()
    {
        var points = GetCurrentPoints();

        Medal.sprite = Medals // linq
            .Where(medal => medal.MinimumPoints <= points) //te medale które zdobył gracz, sprawdzając próg medalu
            .OrderBy(medal => medal.MinimumPoints) // sortujemy od najłatwiejszego progu
            .Last() // wybieramy ostatni, czyli ostatni
            .Image; // i przypisyjemu obrazek

    }

    void RefreshRecord()
    {
        var currentPoints = GetCurrentPoints();
        var recordPoints = PlayerPrefs.GetInt("recordPoints", 0);
        Debug.Log(currentPoints);
        Debug.Log(recordPoints);

        bool isRecord = currentPoints  > recordPoints;

        if (isRecord)
            PlayerPrefs.SetInt("recordPoints", currentPoints);

        Record.SetActive(isRecord);//Obiekt aktywny gdy będzie rekord isRecord=true

        //Record.GetComponent<Renderer>().enabled = isRecord; //komponent widoczny gdy będzie spełnione isRecord tzn gdy będzie rekord

    }

}
