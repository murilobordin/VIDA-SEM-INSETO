using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaJogo : MonoBehaviour
{
    public enum statusDaMorte {VIVO, VENENO, AGROTOXICO, FOGO, SOL }
    [SerializeField]
    private statusDaMorte modoDaMorte;

    private void Start()
    {
        modoDaMorte = statusDaMorte.VIVO;
    }

    public void CarregaCena(string nomeDaCena)
    {
        SceneManager.LoadScene(nomeDaCena);
    }

    public void CausaDaMorte(statusDaMorte causaDaMorte)
    {
        modoDaMorte = causaDaMorte;
    }
}
