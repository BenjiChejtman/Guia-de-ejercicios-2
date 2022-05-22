using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject ObjectToClone;
    int quantity;
    public Text InputField;
    int counter = 0;
    public Text CubosRestantes;
    public Text error;
    string txterror;
    string txterror2;
    string resto;
    int restante;

    // Start is called before the first frame update
    void Start()
    {
        txterror = "Porfavor, ingrese un numero.";
        txterror2 = "Ya llego a la cantidad ingresada.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantaiteObjectToClone()
    {
        quantity = int.Parse(InputField.text);

        if (counter < quantity)                                         
        {
            Instantiate(ObjectToClone);
            counter++;
            CubosRestantes.text = resto;

        }
        else if (counter == quantity)
        {
            error.text = txterror2;
        }
        else if(InputField.text == "")
        {
            error.text = txterror;
        }

        CubosRestantes.text = "Faltan " + (quantity - counter); //va despues de los ifs porque si los pongo antes
                                                                //no va a tener de donde sacar la cantidad counter (creo)
                                                                //PERO SE PONE SI O SI ABAJO DE TODO
                                                                //¡EL CALCULO DE CUANTOS CUBOS FALTAN (O RESTANTES)
                                                                //VA SIEMPRE ABAJO!
    }
}
