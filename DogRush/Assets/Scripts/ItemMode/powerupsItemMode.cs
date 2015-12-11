using UnityEngine;
using System.Collections;

public class powerupsItemMode : MonoBehaviour
{


    public bool doublePoints;
    public bool safeMode;

    public float powerupLength;

    private PowerupManagerItemMode thePowerupManager;

    public Sprite[] powerupSprites;




    // Use this for initialization
    void Start()
    {
        thePowerupManager = FindObjectOfType<PowerupManagerItemMode>();
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
