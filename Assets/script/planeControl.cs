using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeControl : MonoBehaviour
{
    public GameObject unObjeto;
    public int sentido; //para decrecer
    Transform giro; 
    Vector3 valorGiro;
    void Start()
    {
        giro = unObjeto.GetComponent<Transform>(); //hace referncia a la sphera
        valorGiro = new Vector3(0.3f, 0f, 0f) * sentido;
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        giro.Rotate(Vector3.right*sentido); //right 1,0,0  /up 0,1,0  /forward 0,0,1
    }

}
