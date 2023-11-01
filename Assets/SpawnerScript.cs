using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = (60/130);
    private float timer;

    void Update() 
    {
        {
        if (timer > beat)
        {
            GameObject cube = Instantiate(cubes[UnityEngine.Random.Range(0, 2)], points[UnityEngine.Random.Range(0, 9)]);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(Vector3.forward, 90 * UnityEngine.Random.Range(0, 4));
            timer -= beat;
        }
        timer += Time.deltaTime;
    }
    }
}
