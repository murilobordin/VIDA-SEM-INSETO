using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaJogo : MonoBehaviour
{
    public void CarregaCena(string nomeDaCena)
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
