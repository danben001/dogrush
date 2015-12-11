using UnityEngine;
using System.Collections;

/*
* PlatformDestroyerItemMode.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
*
*/

public class PlatformDestroyerItemMode : MonoBehaviour
{

    public GameObject platformDestructionPoint;

    // Use this for initialization
    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < platformDestructionPoint.transform.position.x)
        {
            //Destroy (gameObject);

            gameObject.SetActive(false);
        }

    }
}
