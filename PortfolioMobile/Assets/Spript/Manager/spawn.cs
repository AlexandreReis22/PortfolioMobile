using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject block;
    public Transform cenario;
    public int cont = 6, NumSpawn;
    public float tempSpwan, tempMove;
    public Rigidbody2D rb;
    public BolinhaManager bManager;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (bManager.iniciou)
        {
            tempMove = -30 * Time.deltaTime;
            rb.velocity = new Vector2(0, tempMove);

            if (NumSpawn <= 3)
            {
                tempSpwan += 1 * Time.deltaTime;
            }
            if (tempSpwan >= 4.5 && NumSpawn <= 4)
            {
                spawnar();
                NumSpawn++;
            }
        }       
    }
    public void spawnar()
    {
        for(float i = 0; i < cont; i++)
        {
            float x = i * 0.60f;
            GameObject temp = Instantiate(block);
            temp.transform.position = new Vector2(transform.position.x + x, transform.position.y);
            temp.transform.SetParent(cenario);                              
        }
        tempSpwan = 0;
    }
}
