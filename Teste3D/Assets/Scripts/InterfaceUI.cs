using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceUI : MonoBehaviour
{
    public static GameObject instanciaInterfaceUI;
    private static InterfaceUI _instanciaInterfaceUI;
    public static InterfaceUI InstanciaInterfaceUI {
        get {
            if(_instanciaInterfaceUI == null) {
                _instanciaInterfaceUI = instanciaInterfaceUI.GetComponent<InterfaceUI>();
            }
            return _instanciaInterfaceUI;
        }
    }
    void Awake() {
        instanciaInterfaceUI = FindObjectOfType<InterfaceUI>().gameObject;
    }

    
    public int numObjetos = 0;
    public Text textObjetos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AtualizarInterface();
    }

    public void AtualizarInterface(){
        textObjetos.text = numObjetos+"";
    }

    public void AcrescentarObjeto(){
        numObjetos++;
    }
}
