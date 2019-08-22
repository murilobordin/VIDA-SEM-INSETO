using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaPersonagem : MonoBehaviour
{
    [SerializeField]
    private ControlaPontuacao pontuacao;
    [SerializeField]
    private ControlaJogo diretorDeJogo;

    

    private void OnTriggerEnter2D(Collider2D outroObjeto)
    {
        if (outroObjeto.gameObject.CompareTag("Pontuavel"))
        {
            pontuacao.Pontuar();
        }

        if (outroObjeto.gameObject.CompareTag("Mortifero"))
        {
            this.MataOPersonagem();
        }
    }

    private void MataOPersonagem()
    {
        diretorDeJogo.CarregaCena("TelaDeDerrota");
    }
}
