using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisappearTextUI : MonoBehaviour
{
    public GameObject TextUI;

    // Start is called before the first frame update
    void Start()
    {
        TextUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TextUI.SetActive(!TextUI.activeInHierarchy);
        }
    }
}
