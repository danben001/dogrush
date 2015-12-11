using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

/*
* GameOver.cs
*
* v1.0
*
* 06/12/2015
*
* @author Nathan Ryan, x13448212
*
*/

public class GameOver : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount = 0;
    public float hiScoreCount = 0;

    //Leaderboard
    private string leaderboard = "CgkI-I2pkfweEAIQGQ";

    //Achievements
    private string achievement_500_points = "CgkI-I2pkfweEAIQAQ"; // <GPGSID>
    private string achievement_1000_points = "CgkI-I2pkfweEAIQAg"; // <GPGSID>
    private string achievement_2000_points = "CgkI-I2pkfweEAIQAw"; // <GPGSID>
    private string achievement_3000_points = "CgkI-I2pkfweEAIQBA"; // <GPGSID>
    private string achievement_4000_points = "CgkI-I2pkfweEAIQBQ"; // <GPGSID>
    private string achievement_5000_points = "CgkI-I2pkfweEAIQBg"; // <GPGSID>
    private string achievement_10000_points = "CgkI-I2pkfweEAIQBw"; // <GPGSID>
    private string achievement_20000_points = "CgkI-I2pkfweEAIQCA"; // <GPGSID>

    void Start()
    {
        scoreCount = PlayerPrefs.GetFloat("Score");
        hiScoreCount = PlayerPrefs.GetFloat("HighScore");
    }

    void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);

        if (Social.localUser.authenticated)
        {
            if ((int)scoreCount >= 500)
            {
                //Unlock 500 score achievement on Google Game Services
                Social.ReportProgress(achievement_500_points, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 1000)
            {
                //Unlock 1,000 score achievement on Google Game Services
                Social.ReportProgress(achievement_1000_points, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 2000)

                //Unlock 2,000 score achievement on Google Game Services
                Social.ReportProgress(achievement_2000_points, 100.0f, (bool success) =>
                {
                });
        }

        if ((int)scoreCount >= 3000)
        {
            //Unlock 3,000 score achievement on Google Game Services
            Social.ReportProgress(achievement_3000_points, 100.0f, (bool success) =>
            {
            });
        }

        if ((int)scoreCount >= 4000)
        {
            //Unlock 4,000 score achievement on Google Game Services
            Social.ReportProgress(achievement_4000_points, 100.0f, (bool success) =>
            {
            });
        }

        if ((int)scoreCount >= 5000)
        {
            //Unlock 5,000 score achievement on Google Game Services
            Social.ReportProgress(achievement_5000_points, 100.0f, (bool success) =>
            {
            });
        }

        if ((int)scoreCount >= 10000)
        {
            //Unlock 10,000 score achievement on Google Game Services
            Social.ReportProgress(achievement_10000_points, 100.0f, (bool success) =>
            {
            });
        }

        if ((int)scoreCount >= 20000)
        {
            //Unlock 20,000 score achievement on Google Game Services
            Social.ReportProgress(achievement_20000_points, 100.0f, (bool success) =>
            {
            });
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
