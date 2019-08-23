using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaBarraDeInsolacao : MonoBehaviour
{
    private Slider barraDeInsolação;

    private void Start()
    {
        barraDeInsolação = GetComponent<Slider>();
    }

    public void AtualizaBarraDeInsolacao(float tempoCorrido, float tempoMaximo)
    {
        var insolacao = tempoCorrido / tempoMaximo;
        barraDeInsolação.value = insolacao;
    }
}
