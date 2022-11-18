using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjeto : MonoBehaviour
{
    public GameObject objeto;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        trigger.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        objeto.SetActive(!objeto.activeSelf);
    }

    void OnTriggerStay(Collider other){
        //Debug.Log("Stay");
    }

    void OnTriggerExit(Collider other){
        Debug.Log(!objeto.activeSelf);
        objeto.SetActive(!objeto.activeSelf);
    }
}
