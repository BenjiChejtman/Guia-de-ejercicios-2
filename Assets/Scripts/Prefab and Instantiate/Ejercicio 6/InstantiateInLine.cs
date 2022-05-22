using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateInLine : MonoBehaviour
{
    public GameObject cube;
    public Text InputFieldLimit;

    Vector3 myVector3;
    Vector3 posicionInicial;
    int counter = 0;
    int i = 0;
    //int numLimite;

    string numLimite;
    int numlimite;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial.x = 0;
        cube.transform.position = posicionInicial;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateInLineCube()
    {
        numLimite = InputFieldLimit.text;
        numlimite = int.Parse(numLimite);
        
        //numLimite = int.Parse(InputFieldLimit.text);


        if (counter < numlimite)
        {
            Instantiate(cube);
            counter++;
            myVector3.x = counter;
            cube.transform.position = myVector3;
        }
        else if (numLimite == "")
        {
            Instantiate(cube);
            i++;
            myVector3.x = i;
            cube.transform.position = myVector3;
        }
        
        else if (numlimite < 0)
        {
            Debug.Log("El numero no puede ser negativo.");
        }
    }
}
