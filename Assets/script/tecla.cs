using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tecla : MonoBehaviour
{
    private Transform tamaño;
    public  Vector3 crecimiento=new Vector3(0f,0.9f,0f);
    Vector3 tamOriginal=new Vector3(0f,0f,0f);
    public AudioSource audio;
    //
    private float timer;
    public  float tiempoEntreSonidos=0.1f;
    public bool tipoPiano;
    void Start()
    {
        tamaño = this.GetComponent<Transform>();
        tamOriginal = tamaño.localScale;
        audio = this.GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (tipoPiano)
        {
            audio.Play();
            timer = 0;
        }
        tamaño.localScale = tamOriginal - crecimiento;
    }

    private void OnMouseOver()
    {
        if (!tipoPiano)
        {
            timer += Time.deltaTime;

            if (timer > tiempoEntreSonidos)
            {
                audio.Play();
                timer = 0;
            }
            tamaño.localScale = tamOriginal - crecimiento;

        }
        
    }

    private void OnMouseUp()
    {
        
        audio.Stop();
    }

    private void OnMouseExit()
    {
        tamaño.localScale = tamOriginal;
        
    }
}
