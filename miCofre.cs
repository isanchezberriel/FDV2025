using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miCofre : MonoBehaviour
{
    
    public int tamano;
    // Start is called before the first frame update
    void Start()
    {
        tamano = 3;
        Color.red;
        Debug.Log(tamano);
    }

    // Update is called once per frame
    void Update()
    {
        cambiarTamano();
    }

    void cambiarTamano(){
        tamano = 2 * tamano;
        Debug.Log(tamano);
    }
}
