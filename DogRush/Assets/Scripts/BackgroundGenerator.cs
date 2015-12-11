using UnityEngine;
using System.Collections;

/*
* BackgroundGenerator.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
* @author Jefferson Tolentino, x13452702
*/

public class BackgroundGenerator : MonoBehaviour
{

    public GameObject theBackground;
    public Transform generationPoint;

    public float distanceBetween;

    private float backgroudWidth;

    public ObjectPooler theObjectPool;

    // Use this for initialization
    void Start()
    {
        backgroudWidth = theBackground.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + backgroudWidth + distanceBetween, transform.position.y, transform.position.z);

            //Instantiate(theBackground, transform.position, transform.rotation );

            GameObject newBackground = theObjectPool.GetPooledObject();

            newBackground.transform.position = transform.position;
            newBackground.transform.rotation = transform.rotation;

            newBackground.SetActive(true);

        }

    }
}
