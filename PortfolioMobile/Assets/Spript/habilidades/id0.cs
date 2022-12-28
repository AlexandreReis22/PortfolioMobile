using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class id0 : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool hab;
    public float t;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hab = gameObject.GetComponent<habilidades>();
    }
    private void Update()
    {
        if (!hab)
        {
            t += Time.deltaTime;
            rb.AddForce(new Vector2(Random.Range(-2, 2), 3), ForceMode2D.Impulse);            
        }
        if(t > 0.1f)
        {
            hab = true;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("esquerda"))
        {
            rb.AddForce(new Vector2(-20, 30), ForceMode2D.Impulse);
        }
        else if (collision.collider.tag.Equals("direita"))
        {
            rb.AddForce(new Vector2(20, 30), ForceMode2D.Impulse);
        }
        if (collision.collider.tag.Equals("bloquinho"))
        {
           Destroy(collision.gameObject);
        } 
        else if (collision.collider.tag.Equals("gameOver"))
        {
            Destroy(gameObject);
        }
    }
}
