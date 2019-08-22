using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObstaculo : MonoBehaviour
{

    [Header("Atributos do Obstaculo")]
    [SerializeField]
    private int quantidadeDeObstaculos;
    [SerializeField]
    private int indiceDoObstaculo;
    [SerializeField]
    private ControlaReserva reserva;


    void Awake()
    {
        reserva = GameObject.FindObjectOfType<ControlaReserva>();
    }

    public void AtivaObstaculoFilho()
    {
        indiceDoObstaculo = Random.Range(0, quantidadeDeObstaculos);
        this.gameObject.transform.GetChild(indiceDoObstaculo).gameObject.SetActive(true);
    }

    public void DesativaOsObstaculos()
    {
        this.gameObject.transform.GetChild(indiceDoObstaculo).gameObject.SetActive(false);
    }
}
