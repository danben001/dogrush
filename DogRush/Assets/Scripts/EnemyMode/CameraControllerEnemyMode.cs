using UnityEngine;
using System.Collections;

/*
* CameraControllerEnemyMode.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
*/

public class CameraControllerEnemyMode : MonoBehaviour
{

    public PlayerControllerEnemyMode thePlayer;

    private Vector3 lastPlayerPosotion;
    private float distanceToMove;

    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerControllerEnemyMode>();
        // initializes player position when game loads 
        lastPlayerPosotion = thePlayer.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        distanceToMove = thePlayer.transform.position.x - lastPlayerPosotion.x;

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        lastPlayerPosotion = thePlayer.transform.position;
    }
}
