using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidadeDaBola ;
    public Rigidbody2D oRigidbody2D ;
    public AudioSource somDaBola ;
    public bool jogoIniciou ;

    void Update()
    {
        if(jogoIniciou == false)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                MovimentarBolinha();
                jogoIniciou = true;
            }
        }
    }
    private void MovimentarBolinha()
    {
        oRigidbody2D.velocity = Vector2.up * velocidadeDaBola;
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        somDaBola.Play();
    }
}
