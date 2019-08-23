using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaPersonagem : MonoBehaviour
{
    [Header("Status do Jogador")]
    [SerializeField]
    private float tempoDeVida;
    [Header("Atributos do Jogador")]
    [SerializeField]
    private ControlaPontuacao pontuacao;
    [SerializeField]
    private ControlaJogo diretorDeJogo;
    [SerializeField]
    private ControlaBarraDeInsolacao insolacao;

    private float tempoRealDeVida;

    private void Start()
    {
        tempoRealDeVida = tempoDeVida;
    }

    private void Update()
    {
        tempoRealDeVida -= Time.deltaTime;

        insolacao.AtualizaBarraDeInsolacao(tempoRealDeVida, tempoDeVida);

        if (tempoRealDeVida <= 0)
        {
            this.MataOPersonagem();
            this.diretorDeJogo.CausaDaMorte(ControlaJogo.statusDaMorte.SOL);
        }
    }

    private void OnTriggerEnter2D(Collider2D outroObjeto)
    {
        if (outroObjeto.gameObject.CompareTag("Pontuavel"))
        {
            this.pontuacao.Pontuar();
        }

        if (outroObjeto.gameObject.CompareTag("Mortifero"))
        {
            this.DescobreACausaDaMorte(outroObjeto.gameObject);
            this.MataOPersonagem();
        }
    }

    private void MataOPersonagem()
    {
        this.diretorDeJogo.CarregaCena("TelaDeDerrota");
    }

    private void DescobreACausaDaMorte(GameObject objeto)
    {
        var nomeDoObjeto = objeto.gameObject.name;

        if (nomeDoObjeto == "Centro Da Flor Envenenada")
            this.diretorDeJogo.CausaDaMorte(ControlaJogo.statusDaMorte.VENENO);
        else if (nomeDoObjeto == "Nuvem")
            this.diretorDeJogo.CausaDaMorte(ControlaJogo.statusDaMorte.AGROTOXICO);
        else if (nomeDoObjeto == "Fogo0" || nomeDoObjeto == "Fogo1")
            this.diretorDeJogo.CausaDaMorte(ControlaJogo.statusDaMorte.FOGO);
    }
}
