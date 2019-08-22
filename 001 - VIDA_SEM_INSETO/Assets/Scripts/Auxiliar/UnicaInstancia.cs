using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicaInstancia : MonoBehaviour
{
    private void Awake()
    {
        var outrosObjetos = GameObject.FindGameObjectsWithTag(this.tag);
        foreach(var objeto in outrosObjetos)
        {
            if (objeto != this.gameObject)
            {
                Destroy(objeto);
            }
        }
    }
}
