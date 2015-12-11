using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

/*
* GameOverEnemyMode.cs
*
* v1.0
*
* 06/12/2015
*
* @author Nathan Ryan, x13448212
*
*/

public class GameOverEnemyMode : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount = 0;
    public float hiScoreCount = 0;

    //Leaderboard
    private string leaderboard = "CgkI-I2pkfweEAIQGw";

    //Achievements
    private string achievement_500_enemy_points = "CgkI-I2pkfweEAIQEQ"; // <GPGSID>
    private string achievement_1000_enemy_points = "CgkI-I2pkfweEAIQEg"; // <GPGSID>
    private string achievement_2000_enemy_points = "CgkI-I2pkfweEAIQEw"; // <GPGSID>
    private string achievement_3000_enemy_points = "CgkI-I2pkfweEAIQFA"; // <GPGSID>
    private string achievement_4000_enemy_points = "CgkI-I2pkfweEAIQFQ"; // <GPGSID>
    private string achievement_5000_enemy_points = "CgkI-I2pkfweEAIQFg"; // <GPGSID>
    private string achievement_10000_enemy_points = "CgkI-I2pkfweEAIQFw"; // <GPGSID>
    private string achievement_20000_enemy_points = "CgkI-I2pkfweEAIQGA"; // <GPGSID>

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

                //Unlock achievement on Google Game Services
                Social.ReportProgress(achievement_500_enemy_points, 100.0f, (bool success) =>
                {
                });
            }


            if ((int)scoreCount >= 1000)
            {

                Social.ReportProgress(achievement_1000_enemy_points, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 2000)
            {

                Social.ReportProgress(achievement_2000_enemy_points, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 3000)
            {

                Social.ReportProgress(achievement_3000_enemy_points, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 4000)
            {

                Social.ReportProgress(achievement_4000_enemy_points, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 5000)
            {

                Social.ReportProgress(achievement_5000_enemy_points, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 10000)
            {

                Social.ReportProgress(achievement_10000_enemy_points, 100.0f, (bool success) =>
                {
                });
            }

            if ((int)scoreCount >= 20000)
            {

                Social.ReportProgress(achievement_20000_enemy_points, 100.0f, (bool success) =>
                {
                });
            }
        }

    }

    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
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
}
