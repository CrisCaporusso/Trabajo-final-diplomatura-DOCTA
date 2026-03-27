using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject collectiblePrefab;

    public int cantidad = 10;

    public float rangoX = 10f;
    public float rangoZ = 10f;

    void Start()
    {
        for (int i = 0; i < cantidad; i++)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        float x = UnityEngine.Random.Range(-rangoX, rangoX);
        float z = UnityEngine.Random.Range(-rangoZ, rangoZ);

        Vector3 posicion = new Vector3(x, 1f, z);

        Instantiate(collectiblePrefab, posicion, Quaternion.identity);
    }
}
