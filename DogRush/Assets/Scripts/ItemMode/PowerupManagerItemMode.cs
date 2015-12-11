using UnityEngine;
using System.Collections;

public class PowerupManagerItemMode : MonoBehaviour
{


    private bool doublePoints;
    private bool safeMode;
    private bool powerupActive;
    private float powerupLengthCounter;

    private ScoreManagerItemMode theScoreManager;
    private PlatformGeneratorItemMode thePlatformGenerator;
    private float normalPointsPerSecond;
    private float spikeRate;
    private float boneRate;


    private PlatformDestroyer[] spikeList;
    private PlatformDestroyer[] boneList;

    // Use this for initialization
    void Start()
    {

        theScoreManager = FindObjectOfType<ScoreManagerItemMode>();
        thePlatformGenerator = FindObjectOfType<PlatformGeneratorItemMode>();

    }

    // Update is called once per frame
    void Update()
    {

        if (powerupActive)
        {

            powerupLengthCounter -= Time.deltaTime;

            if (doublePoints)
            {

                thePlatformGenerator.randomBoneThreshold = 200f;
            }

            if (safeMode)
            {

                thePlatformGenerator.randomSpikeThreshold = 0f;


            }

            if (powerupLengthCounter <= 0)
            {

                thePlatformGenerator.randomSpikeThreshold = spikeRate;
                thePlatformGenerator.randomBoneThreshold = boneRate;

                powerupActive = false;
            }

        }


    }


    public void ActivatePowerup(bool points, bool safe, float time)
    {

        doublePoints = points;

        safeMode = safe;

        powerupLengthCounter = time;

        spikeRate = thePlatformGenerator.randomSpikeThreshold;
        boneRate = thePlatformGenerator.randomBoneThreshold;


        if (safeMode)
        {

            spikeList = FindObjectsOfType<PlatformDestroyer>();


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


        }



        powerupActive = true;
    }

}
