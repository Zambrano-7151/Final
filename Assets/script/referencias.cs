using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class referencias : MonoBehaviour
{
    //para referirme a un objeto
    public GameObject unObjeto;
    public int sentido; //para decrecer
    Transform tamaño; 
    Vector3 scala;
    void Start()
    {
        tamaño = unObjeto.GetComponent<Transform>(); //hace referncia a la sphera
        scala = new Vector3(0.1f, 0.1f, 0.1f) * sentido;

    }

    // Update is called once per frame
    void Update()
    {
        //tamaño.localScale += scala; //de ese unbejto en su objeto scale hay un valor y lo uqe hacems es agregar (1,1,1) +(0.1, 0.1,0.1)
    }

    private void OnMouseDown()
    {
        tamaño.localScale += scala;
    }
    
    
    
    private void Awake()
    {
        Debug.Log("Este es el awake");
    }
    

   
    private void OnMouseEnter()
    {
        Debug.Log("Se activó al ingresar el mouser");
    }

    private void OnMouseExit()
    {
        Debug.Log("Se activó al salir el mouse");
    }


}
