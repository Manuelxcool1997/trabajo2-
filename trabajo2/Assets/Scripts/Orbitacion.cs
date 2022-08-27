using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbitacion : MonoBehaviour
{
    [SerializeField]
    private Vector3 Velocidad;
   
    [SerializeField]
    private float acceleracion = 2;

   

    [SerializeField] new Camera  camera;
    [SerializeField] Transform target;


    private void Update()
    {
       
        MakeOrbit();
    }
   

    public void MakeOrbit()
    {
        Vector3 accelerationOrbit = (target.position - transform.position) ;
        Velocidad += accelerationOrbit * Time.deltaTime;
        transform.position += Velocidad * Time.deltaTime;
    }
}
