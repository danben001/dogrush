using UnityEngine;
using System.Collections;

/*
* powerupsEnemyMode.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
*/

public class powerupsEnemyMode : MonoBehaviour
{

    public bool doublePoints;
    public bool safeMode;

    public float powerupLength;

    private PowerupManagerEnemyMode thePowerupManager;

    public Sprite[] powerupSprites;


    // Use this for initialization
    void Start()
    {
        thePowerupManager = FindObjectOfType<PowerupManagerEnemyMode>();
    }

    void Awake()
    {
        int powerupSelector = Random.Range(0, 3);

        switch (powerupSelector)
        {
            case 0: doublePoints = true;
                break;

            case 1: safeMode = true;
                break;

            case 2: safeMode = true;
                doublePoints = true;
                break;
        }

        GetComponent<SpriteRenderer>().sprite = powerupSprites[powerupSelector];
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            thePowerupManager.ActivatePowerup(doublePoints, safeMode, powerupLength);
        }

        gameObject.SetActive(false);

    }
}
