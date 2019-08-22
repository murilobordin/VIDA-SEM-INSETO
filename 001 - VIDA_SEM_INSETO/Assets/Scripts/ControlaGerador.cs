using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ControlaGerador : MonoBehaviour
{

    [Header("Atributos do Gerador")]
    [SerializeField]
    private float tempoParaGerar;
    [SerializeField]
    private ControlaReserva reserva;
    [SerializeField]
    private float tempoCorrido;
    [Header("Posição de Geração dos obstáculos")]
    [SerializeField]
    private float posicaoMinY;
    [SerializeField]
    private float posicaoMaxY;
    
    void Start()
    {
        reserva = GameObject.FindObjectOfType<ControlaReserva>();
    }
    
    void Update()
    {
        tempoCorrido += Time.fixedDeltaTime;
        if (tempoCorrido >= tempoParaGerar && this.reserva.TemObstaculos())
        {
            tempoCorrido = 0f;
            this.AtivaObstaculoPai();
        }
    }

    private void AtivaObstaculoPai()
    {
        var objeto = reserva.PegarObjeto();
        objeto.transform.position = this.GeraPosição();
    }

    private Vector3 GeraPosição()
    {
        var novaAltura = Random.Range(posicaoMinY, posicaoMaxY);
        var novaPosicao = new Vector3(this.transform.position.x, novaAltura, this.transform.position.z);
        return novaPosicao;
    }
}
