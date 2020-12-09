using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public CharacterController controlador;

    public float velocidad;
    public float gravedad;
    public Vector3 direccion;
    public float rotacion;
    public float velocidadRotacion = 5f;
    void Start()
    {
        this.controlador = gameObject.GetComponent<CharacterController>();
        velocidad = 5f;
        gravedad = 9.8f;
    }
    void Update()
    {
        //controlador.SimpleMove(Vector3.right*velocidad); //hacia la dereca
        direccion = transform.TransformDirection(new Vector3(Input.GetAxis("Vertical"),0,0)*velocidad);
        direccion -= new Vector3(0,  gravedad*Time.deltaTime, 0); //total control, la velocidad es la misma en una compu lenta y en una rapida
        rotacion = Input.GetAxis("Horizontal")*velocidadRotacion;
        //direccion.z = Input.GetAxis("Vertical") * velocidad;
        controlador.transform.Rotate(new Vector3(0f,rotacion,0f));
        controlador.Move(direccion*velocidad*Time.deltaTime);
    }
}
