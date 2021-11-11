using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoLINEAR : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float force;

    private void awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        rb2d = AddForce(tranform.right * force);
    }
}
