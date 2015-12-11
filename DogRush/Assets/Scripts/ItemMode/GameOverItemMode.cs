using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

/*
* GameOverItemMode.cs
*
* v1.0
*
* 06/12/2015
*
* @author Nathan Ryan, x13448212
*
*/

public class GameOverItemMode : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount = 0;
    public float hiScoreCount = 0;

    //Leaderboard
    private string leaderboard = "CgkI-I2pkfweEAIQGg";

    //Achievements
    private string achievement_collect_5_items = "CgkI-I2pkfweEAIQCQ"; // <GPGSID>
    private string achievement_collect_10_items = "CgkI-I2pkfweEAIQCg"; // <GPGSID>
    private string achievement_collect_20_items = "CgkI-I2pkfweEAIQCw"; // <GPGSID>
    private string achievement_collect_30_items = "CgkI-I2pkfweEAIQDA"; // <GPGSID>
    private string achievement_collect_40_items = "CgkI-I2pkfweEAIQDQ"; // <GPGSID>
    private string achievement_collect_50_items = "CgkI-I2pkfweEAIQDg"; // <GPGSID>
    private string achievement_collect_100_items = "CgkI-I2pkfweEAIQDw"; // <GPGSID>
    private string achievement_collect_200_items = "CgkI-I2pkfweEAIQEA"; // <GPGSID>

    void Start()
    {
        scoreCount = PlayerPrefs.GetFloat("Score");
        hiScoreCount = PlayerPrefs.GetFloat("HighScore");
    }

    void Update()
    {
        scoreText.text = "Items Collected: " + Mathf.Round(scoreCount);
        hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);

        if (Social.localUser.authenticated)
        {
            if ((int)scoreCount >= 5)
            {

                //Unlock collect 5 achievement on Google Game Services
                Social.ReportProgress(achievement_collect_5_items, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 10)
            {

                //Unlock collect 10 achievement on Google Game Services
                Social.ReportProgress(achievement_collect_10_items, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 20)
            {
                //Unlock collect 20 achievement on Google Game Services
                Social.ReportProgress(achievement_collect_20_items, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 30)
            {
                //Unlock collect 30 achievement on Google Game Services
                Social.ReportProgress(achievement_collect_30_items, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 40)
            {
                //Unlock collect 40 achievement on Google Game Services
                Social.ReportProgress(achievement_collect_40_items, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 50)
            {
                //Unlock collect 50 achievement on Google Game Services
                Social.ReportProgress(achievement_collect_50_items, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 100)
            {
                //Unlock collect 100 achievement on Google Game Services
                Social.ReportProgress(achievement_collect_100_items, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 200)
            {
                //Unlock collect 200 achievement on Google Game Services
                Social.ReportProgress(achievement_collect_200_items, 100.0f, (bool success) =>
                {
                });
            }
        }

    }

    public void SubmitScore()
    {
        if (Social.localUser.authenticated)
        { //(cast float to int) can only submit int score to play services
            Social.ReportScore((int)scoreCount, leaderboard, (bool success) =>
            {
                if (success)
                {
                    ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(leaderboard);
                }
                else
                {
                    //Debug.Log("Login failed for some reason");
                }
            });
        }
    }

    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }

}
