using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

/*
* MainMenu.cs
*
* v1.0
*
* 06/12/2015
*
* @author Nathan Ryan, x13448212
*
*/

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        PlayGamesPlatform.Activate();

        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                Debug.Log("You've successfully logged in");
            }
            else
            {
                Debug.Log("Login failed for some reason");
            }
        });
    }

    public void LoadScene(int level)
    {

        Application.LoadLevel(level);
    }

    public void LoadAchievements()
    {
        Social.ShowAchievementsUI();
    }

    public void LoadLeaderboards()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkI-I2pkfweEAIQGQ");
    }
}
