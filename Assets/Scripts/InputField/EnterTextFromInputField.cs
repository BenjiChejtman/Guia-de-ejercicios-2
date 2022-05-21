using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterTextFromInputField : MonoBehaviour
{
    string mensaje;
    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShowMessageFromInputField()
    {
        mensaje = textUI.text;
        Debug.Log(mensaje);
    }
}
