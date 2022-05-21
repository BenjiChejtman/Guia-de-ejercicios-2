using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiatePrefabDesdeNuemeroIngresadoPorInputFieldConFor : MonoBehaviour
{
    public GameObject prefab;
    public Text InputCantidad;
    int cant;

    public void InstantiatePrefabCantidadDeVecesDesdeInputFieldConFor()
    {
        cant = int.Parse(InputCantidad.text);
        
        if (cant >= 0)
        {
            for (int i = 0; i < cant; i++)
            {
                Instantiate(prefab);
            }
        }
        else if (cant < 0)
        {
            Debug.Log("Porfavor, elija un numero que no sea negativo.");
        }
        
        
    }
}
