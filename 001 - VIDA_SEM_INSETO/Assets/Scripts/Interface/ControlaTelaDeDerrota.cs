using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaTelaDeDerrota : MonoBehaviour
{
    private ControlaJogo diretorDoJogo;

    private void Start()
    {
        diretorDoJogo = GameObject.FindObjectOfType<ControlaJogo>();
    }
    
    public void JogarNovamente()
    {
        diretorDoJogo.CarregaCena("Jogo");
    }
}
