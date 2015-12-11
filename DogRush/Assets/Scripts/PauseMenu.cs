using UnityEngine;
using System.Collections;

/*
* PauseMenu.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
*/

public class PauseMenu : MonoBehaviour
{

    public GameObject PausedMenu;

    public void pauseGame()
    {
        Time.timeScale = 0f;
        PausedMenu.SetActive(true);
    }

    public void resumeGame()
    {
        Time.timeScale = 1f;
        PausedMenu.SetActive(false);
    }

    public void QuitMenu()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(0);
    }
}
