using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class moverSphera : MonoBehaviour
{
    // GameObject  this
    //Transform  position
    Transform posicion;
    Vector3 newPosicion;
    
    void Start()
    {
        posicion = this.GetComponent<Transform>();
        newPosicion= new Vector3(0f,0f,0f);
    }

    private void OnMouseDown()
    {
        newPosicion=new Vector3(Random.Range(-10,10),Random.Range(-10,10),Random.Range(-10,10));
        posicion.position = newPosicion;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
