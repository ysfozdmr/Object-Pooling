using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;
    void Start()
    {
        objectPooler = ObjectPooler.instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        objectPooler.ObjectSpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
