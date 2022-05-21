using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextenUIdeInputfield : MonoBehaviour
{
    public Text inputfield;
    public Text TextUI;

    public void InputfieldTextInTextUI()
    {
        if(inputfield.text != "")
        {
            TextUI.text = inputfield.text;
        }
        else if (inputfield.text == "")
        {
            Debug.Log("Error, ingrese algo en el inputfield.");
        }
    }
}
