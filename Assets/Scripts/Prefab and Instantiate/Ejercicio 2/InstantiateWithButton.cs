using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateWithButton : MonoBehaviour
{
    public GameObject ObjectToClone;
    int counter = 0;

    public void InstantiateObjectToClone()
    {
        while(counter < 1)
        {
            Instantiate(ObjectToClone);
            counter++;
        }
            Debug.Log("Instancia ya creada.");
    }
}
