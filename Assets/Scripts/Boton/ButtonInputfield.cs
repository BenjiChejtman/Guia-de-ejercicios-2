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
    {
        inputfield.SetActive(!inputfield.activeInHierarchy);
    }
}
