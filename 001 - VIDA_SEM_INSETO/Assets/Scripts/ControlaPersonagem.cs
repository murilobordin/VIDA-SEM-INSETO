using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaPersonagem : MonoBehaviour
{
    private ControlaPontuacao pontuacao;

    private void Start()
    {
        pontuacao = GameObject.FindObjectOfType<ControlaPontuacao>();
    }

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
        //CarregaCenaDeMorte
    }
}
