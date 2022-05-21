using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjectWithButton : MonoBehaviour
{
    public GameObject Cube;
    // Start is called before the first frame update

    public void InstantiateWithButtonObject()
    {
        Instantiate(Cube);
    }
}
