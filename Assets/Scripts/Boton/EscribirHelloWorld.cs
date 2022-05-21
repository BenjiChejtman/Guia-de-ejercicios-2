using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscribirHelloWorld : MonoBehaviour
{
    public string mensaje;

    public void WriteOnConsole()
    {
        Debug.Log(mensaje);
    }
}
