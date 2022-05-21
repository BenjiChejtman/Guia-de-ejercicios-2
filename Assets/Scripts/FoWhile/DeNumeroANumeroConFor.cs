using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeNumeroANumeroConFor : MonoBehaviour
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

    public void DeNumeroANumero2()
    {
        numero1 = int.Parse(num1.text);
        numero2 = int.Parse(num2.text);

        if (numero1 < numero2)
        {
            for (int i = numero1;  i <= numero2; i++)
            {
                Debug.Log(i);
            }
        }
        else if (numero1 > numero2)
        {
            for (int i = numero2; i <= numero1; i--)
            {
                Debug.Log(i);
            }
        }
        else if (numero1 == numero2 || numero2 == numero1)
        {
            Debug.Log("Los numeros son iguales");
        }
    }
}
