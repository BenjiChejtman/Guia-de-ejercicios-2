using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumeroPorSiMismoDesdeInputFieldATextUI : MonoBehaviour
{
    public Text NumeroDesdeInputField;
    public Text TextUI;
    int num;
    int res;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NumeroPorSiMismo()
    {
        if (NumeroDesdeInputField.text != "")
        {
            num = int.Parse(NumeroDesdeInputField.text);
            res = num * num;
            TextUI.text = "El resultado es " + res; //para mostrar un int en un TextUI
                                                    //simplemente ponemos algo de texto y luego le sumamos el int, como en este caso ("..." + res  POR EJEMPLO)
        }
        else if (NumeroDesdeInputField.text == "")
        {
            Debug.Log("Error, ingrese algo en el inputfield.");
        }
    }
    
}