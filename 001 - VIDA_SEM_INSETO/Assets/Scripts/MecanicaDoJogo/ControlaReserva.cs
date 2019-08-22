using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaReserva : MonoBehaviour
{
    [Header("Atributos da Reserva")]
    [SerializeField]
    private GameObject obstaculo;
    [SerializeField]
    private int quantidadeDeObstaculos;

    private Stack<GameObject> reservaDeObstaculo;

    private void Awake()
    {
        reservaDeObstaculo = new Stack<GameObject>();
        this.CriarReserva();
    }

    private void CriarReserva()
    {
        for(var i=0; i < quantidadeDeObstaculos; i++)
        {
            this.CriaObstaculo();
        }
    }

    private void CriaObstaculo()
    {
        var objeto = GameObject.Instantiate(obstaculo, this.transform);
        this.DevolveObjeto(objeto);
    }

    public void DevolveObjeto(GameObject objeto)
    {
        objeto.SetActive(false);
        reservaDeObstaculo.Push(objeto);
    }

    public GameObject PegarObjeto()
    {
        var objeto = reservaDeObstaculo.Pop();
        objeto.SetActive(true);
        objeto.GetComponent<ControlaObstaculo>().AtivaObstaculoFilho();
        return objeto;
    }
    
    public bool TemObstaculos()
    {
        return this.reservaDeObstaculo.Count > 0;
    }
}
