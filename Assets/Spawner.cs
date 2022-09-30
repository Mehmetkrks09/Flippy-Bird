using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{

    public bird BirdObject;
    public GameObject Pipes;
    public float height;
    public float time =2f;

    void Start()
    {
        StartCoroutine(SpawnPipe(time));      
    }


    public IEnumerator SpawnPipe(float time)
    {
        while (!BirdObject.isDead)
        {
            Instantiate(Pipes, new Vector3(3, Random.Range(-height, height), 0), quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
