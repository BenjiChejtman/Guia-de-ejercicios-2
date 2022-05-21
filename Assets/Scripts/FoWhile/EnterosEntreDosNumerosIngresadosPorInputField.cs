using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterosEntreDosNumerosIngresadosPorInputField : MonoBehaviour
{
    public Text num1;
    public Text num2;
    int numero1;
    int numero2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DiferenciaEntreNumeros()
    {
        numero1 = int.Parse(num1.text);
        numero2 = int.Parse(num2.text);

        if (numero1 < numero2)
        {
            while (numero1 <= numero2)
            {
                Debug.Log(numero1);
                numero1++;
            }   
        }
        else if (numero1 > numero2)
        {
            while (numero2 <= numero1)
            {
                Debug.Log(numero1);
                numero1--;
            }
        }
        else if (numero1 == numero2 || numero2 == numero1)
        {
            Debug.Log("Los numeros son iguales");
        }
    }
}
