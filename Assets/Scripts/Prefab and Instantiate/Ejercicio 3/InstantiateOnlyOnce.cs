using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnlyOnce : MonoBehaviour
{
    public GameObject cube;
    int counter = 0;

    public void InstantiateCubeOnlyOnce()
    {
        while (counter < 1)
        {
            Instantiate(cube);
            counter++;
        }
            Debug.Log("Intancia ya creada.");
    }
}
