using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocos : MonoBehaviour
{
    public int vida;
    public SpriteRenderer sprite;
    public GameMaganer gManeger;

    private void Awake()
    {
        vida = Random.Range(1, 4);
        sprite = GetComponent<SpriteRenderer>();    
        gManeger = FindObjectOfType<GameMaganer>();
    }
    private void Start()
    {        
               
    }
    void Update()
    {
        if(vida == 0)
        {
            gManeger.pontos++;
            Destroy(gameObject);            
        }
        switch (vida) 
        { 
            case 1:
                sprite.color = Color.blue;
                break;
            case 2:
                sprite.color = Color.red;
                break;
            case 3:
                sprite.color = Color.green;
                break;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("bolinha"))
        {
            vida--;
        }
    }
}
