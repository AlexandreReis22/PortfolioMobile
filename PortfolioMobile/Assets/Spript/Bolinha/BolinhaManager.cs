using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolinhaManager : MonoBehaviour
{
    public Rigidbody2D rb;
    public float y;
    public bool iniciou;
    public habilidades hab;
    public Especial esp;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("esquerda") && iniciou)
        {           
            Vector2 pos = new Vector2(-40, y);
            rb.AddForce(pos,ForceMode2D.Impulse);
        } 
        else if (collision.collider.tag.Equals("direita") && iniciou)
        { 
            Vector2 pos = new Vector2(40, y);
            rb.AddForce(pos,ForceMode2D.Impulse);
        } 
        else if (collision.collider.tag.Equals("centro"))
        {
            rb.AddForce(Vector2.up * 40, ForceMode2D.Impulse);
        }        
        if (collision.collider.tag.Equals("blocoEspecial"))
        {
            Destroy(collision.gameObject);
            hab.idHabilidade = esp.especial;
        }
    }
}
