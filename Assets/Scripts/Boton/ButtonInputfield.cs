using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInputfield : MonoBehaviour
{
    public  GameObject inputfield;
    // Start is called before the first frame update
    void Start()
    {
        inputfield.SetActive(false);
    }

    public void ButtonShowsInputfield()
    {/*
        if (inputfield.SetActive(false))
        {
            inputfield.SetActive(true);
        }
        if (inputfield.SetActive(true))
        {
            inputfield.SetActive(false);
        }*/
    }
}
