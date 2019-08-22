using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaBarreira : MonoBehaviour
{
    private ControlaReserva reserva;

    private void Awake()
    {
        reserva = GameObject.FindObjectOfType<ControlaReserva>();
    }

    private void OnTriggerEnter2D(Collider2D outroObjeto)
    {
        if (outroObjeto.gameObject.CompareTag("Obstaculo"))
        {
            outroObjeto.GetComponent<ControlaObstaculo>().DesativaOsObstaculos();
            reserva.DevolveObjeto(outroObjeto.gameObject);
        }
    }
}
