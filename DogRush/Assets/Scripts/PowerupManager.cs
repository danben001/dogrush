using UnityEngine;
using System.Collections;

/*
* PowerupManager.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
*/

public class PowerupManager : MonoBehaviour
{

    private bool doublePoints;
    private bool safeMode;
    private bool powerupActive;
    private float powerupLengthCounter;

    private ScoreManager theScoreManager;
    private PlatformGenerator thePlatformGenerator;
    private float normalPointsPerSecond;
    private float spikeRate;
    private float enemyRate;

    private PlatformDestroyer[] spikeList;
    private PlatformDestroyer[] enemyList;


    // Use this for initialization
    void Start()
    {

        theScoreManager = FindObjectOfType<ScoreManager>();
        thePlatformGenerator = FindObjectOfType<PlatformGenerator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (powerupActive)
        {

            powerupLengthCounter -= Time.deltaTime;

            if (doublePoints)
            {

                theScoreManager.pointsPerSecond = normalPointsPerSecond * 10f;
                theScoreManager.shouldDouble = true;

            }

            if (safeMode)
            {

                thePlatformGenerator.randomSpikeThreshold = 0f;



            }

            if (powerupLengthCounter <= 0)
            {


                theScoreManager.pointsPerSecond = normalPointsPerSecond;
                theScoreManager.shouldDouble = false;
                thePlatformGenerator.randomSpikeThreshold = spikeRate;


                powerupActive = false;
            }

        }


    }


    public void ActivatePowerup(bool points, bool safe, float time)
    {

        doublePoints = points;

        safeMode = safe;

        powerupLengthCounter = time;

        normalPointsPerSecond = theScoreManager.pointsPerSecond;
        spikeRate = thePlatformGenerator.randomSpikeThreshold;



        if (safeMode)
        {

            spikeList = FindObjectsOfType<PlatformDestroyer>();
            enemyList = FindObjectsOfType<PlatformDestroyer>();

            //if(gameObject.name.Contains("AlienCat"))
            //{
            //    gameObject.SetActive(false);
            //}


            for (int i = 0; i < spikeList.Length; i++)
            {

                if (spikeList[i].gameObject.name.Contains("spikes"))
                {
                    spikeList[i].gameObject.SetActive(false);
                }


            }

            for (int i = 0; i < enemyList.Length; i++)
            {

                if (enemyList[i].gameObject.name.Contains("Enemy"))
                {
                    enemyList[i].gameObject.SetActive(false);
                }


            }


        }



        powerupActive = true;
    }

}
