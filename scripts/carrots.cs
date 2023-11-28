using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrots : MonoBehaviour
{   public float velocidad = 5.0f;
    public float velocidadDeRotacion = 60.0f;
    public float amplitud = 0.06f;
    private Vector3 startPosition;
    
    void Start(){
        startPosition = transform.position;
    }
    
    void Update()
    {   
        float newY = startPosition.y + Mathf.Sin(Time.time * velocidad) * amplitud;
        transform.Rotate(Vector3.up * velocidadDeRotacion * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
