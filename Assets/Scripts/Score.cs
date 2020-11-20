using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int score;
    public GameObject scoreObject;
    public GameObject HighestscoreObject;

    public static int highestScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        highestScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
       scoreObject.GetComponent<UnityEngine.UI.Text>().text = "Score : " + score.ToString();
        HighestscoreObject.GetComponent<UnityEngine.UI.Text>().text = "HighestScore : " + PlayerPrefs.GetInt("HighestScore");

          if (score > PlayerPrefs.GetInt("HighestScore"))
          {
              highestScore = score;
              PlayerPrefs.SetInt("HighestScore", highestScore);
          }
       
    }
}
