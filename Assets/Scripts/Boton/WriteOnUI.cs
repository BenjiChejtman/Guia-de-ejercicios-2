using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteOnUI : MonoBehaviour
{
    public string mensaje;
    public Text txtMensaje;

    public void messageOnUI()
    {
        txtMensaje.text = mensaje;
    }
}
