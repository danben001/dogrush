using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

/*
* ScoreManagerItemMode.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
* @author Nathan Ryan, x13448212
*/

public class ScoreManagerItemMode : MonoBehaviour
{

    public Text scoreText2;
    public float scoreCount;

    public bool shouldDouble;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText2.text = "Items Collected: " + Mathf.Round(scoreCount);
    }
    public void AddScore(int pointsToAdd)
    {
        if (shouldDouble)
        {
            pointsToAdd = pointsToAdd * 3;

        }

        scoreCount += pointsToAdd;
    }

    void OnDisable()
    {
        PlayerPrefs.SetFloat("Items Collected: ", Mathf.Round(scoreCount));
    }

}
