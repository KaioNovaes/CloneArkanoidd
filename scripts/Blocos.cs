using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocos : MonoBehaviour
{
    void Start()
    {
       FindObjectOfType<GameManager>().AdicionarBloco(); 
       
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.CompareTag("Bola"))
        {
            
            Destroy(this.gameObject);
        }
    }
}
