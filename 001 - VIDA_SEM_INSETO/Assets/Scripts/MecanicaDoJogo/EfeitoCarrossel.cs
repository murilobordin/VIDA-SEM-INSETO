using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoCarrossel : MonoBehaviour
{
    [Header("Atributos do Parallax")]
    [SerializeField]
    private float velocidade;

    private float tamanhoRealDaImagem;
    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = this.transform.position;
        float tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escalaDaImagem = this.transform.localScale.x;
        tamanhoRealDaImagem = tamanhoDaImagem * escalaDaImagem;
    }

    
    void Update()
    {
        float deslocamento = Mathf.Repeat(velocidade * Time.time, tamanhoRealDaImagem);
        this.transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
