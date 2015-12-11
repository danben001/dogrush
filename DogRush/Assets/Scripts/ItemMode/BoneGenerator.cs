using UnityEngine;
using System.Collections;

/*
* BoneGeneratorItemMode.cs
*
* v1.0
*
* 06/12/2015
*
* @reference gamesplusjames https://www.youtube.com/playlist?list=PLiyfvmtjWC_XmdYfXm2i1AQ3lKrEPgc9-
*
*/

public class BoneGeneratorItemMode : MonoBehaviour
{


    public ObjectPooler bonePool;

    public float distanceBetweenCoins;

    // Use this for initialization
    public void SpawnBones(Vector3 startPosition)
    {
        GameObject bone1 = bonePool.GetPooledObject();
        bone1.transform.position = startPosition;
        bone1.SetActive(true);

        GameObject bone2 = bonePool.GetPooledObject();
        bone2.transform.position = new Vector3(startPosition.x - distanceBetweenCoins, startPosition.y, startPosition.z);
        bone2.SetActive(true);

        GameObject bone3 = bonePool.GetPooledObject();
        bone3.transform.position = new Vector3(startPosition.x + distanceBetweenCoins, startPosition.y, startPosition.z);
        bone3.SetActive(true);
    }
}
