using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
* ScoreManagerEnemyMode.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
* @author Nathan Ryan, x13448212
*/

public class ScoreManagerEnemyMode : MonoBehaviour
{

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

    public bool shouldDouble;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame


    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }


        scoreText.text = "Score: " + Mathf.Round(scoreCount);

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
        PlayerPrefs.SetFloat("Score", (float)(scoreCount));
    }
}
