using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaPontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    private int pontos;

    public void Pontuar()
    {
        pontos++;
        this.AtualizaTextoPontuacao();
    }

    private void AtualizaTextoPontuacao()
    {
        textoPontuacao.text = pontos.ToString();
    }
}
