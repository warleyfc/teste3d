using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoColetavel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        InterfaceUI.InstanciaInterfaceUI.AcrescentarObjeto();
        gameObject.SetActive(false);
    }
}
