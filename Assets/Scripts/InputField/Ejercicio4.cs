using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio4 : MonoBehaviour
{
    public Text InputField1;
    public Text InputField2;
    public Text TextUI1;
    public Text TextUIError1;
    public Text TextUIError2;

    //int num1;
    //int num2;
    int divi;
    //string texto1;
    //string texto2;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DiviDosNumeros()
    {
        
        divi = int.Parse(InputField1.text) / int.Parse(InputField2.text);

        //texto1 = InputField1.text;  //se fija que hay en el inputfield al apretar el boton.
        //texto2 = InputField2.text;

        if (InputField1.text != "" && InputField2.text != "" && int.Parse(InputField2.text) != 0)
        {
            TextUI1.text = "El resultado de la division es " + divi;
        }
        else if (InputField1.text == "" || InputField2.text == "")
        {
            TextUIError1.text = "Ingrese un numero en cada InputField porfavor.";
        }
        else if (int.Parse(InputField2.text) == 0)
        {
            TextUIError2.text = "Ingrese un numero distinto a 0 en el segundo InputField porfavor.";
        }
        
    }
}
