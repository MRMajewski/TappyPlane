using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

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


	void Start () {
        RefreshPoints();
        RefreshMedal();
        RefreshRecord();

    }

    int GetCurrentPoints()
    {
       return PlayerPrefs.GetInt("currentPoints", 0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("level1");
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



        bool isRecord = currentPoints  > recordPoints;

        if (isRecord)
            PlayerPrefs.SetInt("recordPoints", currentPoints);

        Record.SetActive(isRecord);//Obiekt aktywny gdy będzie rekord isRecord=true


    }

}
