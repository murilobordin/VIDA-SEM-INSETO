using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPersonagem : MonoBehaviour
{

    private Rigidbody2D rb2D;

    [Header ("Atributos de Física")]
    [SerializeField]
    private float forcaDeImpulso;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        ControlaImpulso();
    }

    private void ControlaImpulso()
    {
        if (Input.GetButton("Fire1"))
        {
            rb2D.velocity = Vector2.zero;
            rb2D.AddForce(new Vector2(0f, forcaDeImpulso), ForceMode2D.Impulse);
        }
    }
}
