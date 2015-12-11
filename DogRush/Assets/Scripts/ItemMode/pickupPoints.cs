using GooglePlayGames;
using System.Collections;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

/*
* pickupPointsItemMode.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
*
*/

public class pickupPointsItemMode : MonoBehaviour
{

    public int scoreToGive;

    private ScoreManagerItemMode theScoreManager;

    // Use this for initialization
    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManagerItemMode>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {

            theScoreManager.AddScore(scoreToGive);
            gameObject.SetActive(false);
        }
    }

}
