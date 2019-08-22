using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaObstaculo : MonoBehaviour
{

    [Header("Atributos de Física")]
    [SerializeField]
    private float velocidade;
    
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
