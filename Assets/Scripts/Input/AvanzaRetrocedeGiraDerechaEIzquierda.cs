using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvanzaRetrocedeGiraDerechaEIzquierda : MonoBehaviour
{
    public float movement;
    public float movement2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, movement);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, movement);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, movement2, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, movement2, 0);
        }
    }
}
