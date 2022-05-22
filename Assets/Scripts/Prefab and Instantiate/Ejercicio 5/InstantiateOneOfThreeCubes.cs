using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateOneOfThreeCubes : MonoBehaviour
{
    public Text txtCuboSeleccionado;
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    string msjCuboSeleccionado1;
    string msjCuboSeleccionado2;
    string msjCuboSeleccionado3;
    GameObject CuboSeleccionado;
    GameObject DestroyCube;

    // Start is called before the first frame update
    void Start()
    {
        msjCuboSeleccionado1 = "Usted selecciono el primer cubo.";
        msjCuboSeleccionado2 = "Usted selecciono el segundo cubo.";
        msjCuboSeleccionado3 = "Usted selecciono el tercer cubo.";
    }

    public void InstantiateFirstCube()
    {
        txtCuboSeleccionado.text = msjCuboSeleccionado1;
        CuboSeleccionado = Cube1;
    }

    public void InstantiateSecondCube()
    {
        txtCuboSeleccionado.text = msjCuboSeleccionado2;
        CuboSeleccionado = Cube2;
    }

    public void InstantiateThirdCube()
    {
        txtCuboSeleccionado.text = msjCuboSeleccionado3;
        CuboSeleccionado = Cube3;
    }

    public void Aceptar()
    {
        DestroyCube = Instantiate(CuboSeleccionado);
        Destroy(DestroyCube, 2);    //asi estamos diciendo que se estruya el clonado, y no el CuboSeleccionado. 
                                    //Si yo pondria en vez de destroycube en el destroy y pondria CuboSeleccionado
                                    //No me destruiria nada, porque me tendria que destruir el prefab,
                                    //pero si le pongo que el DestroyCube (el cubo a destruir) es igual al cubo instanciado o clon
                                    //ahi si voy a poder destruir los cubos instanciados o clonados, en este caso los destruyo
                                    //al cabo de dos segundos de haber sido creados.
    }

}
