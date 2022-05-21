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
        
        if (counter < quantity)                                         //falta poner los cubos restantes en el Text UI.
        {
            Instantiate(ObjectToClone);
            counter++;
            CubosRestantes.text = resto;

        }
        else if (counter == quantity)
        {
            error.text = txterror2;
        }
        else
        {
            error.text = txterror;
        }
    }
}
