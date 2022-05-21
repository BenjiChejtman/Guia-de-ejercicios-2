using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeCeroACien : MonoBehaviour
{
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
      while(counter <= 100)
        {
            Debug.Log(counter);
            counter++;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
