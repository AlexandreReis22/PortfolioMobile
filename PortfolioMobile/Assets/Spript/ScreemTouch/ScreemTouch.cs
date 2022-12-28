using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreemTouch : MonoBehaviour
{
    public BolinhaManager bManager;
    public GameObject telaInicial;
        
    void Start()
    {
        
    }
    
    void Update()
    {
        if(Input.touchCount > 0)
        {
            if(bManager)
            {
                moveTouch();
            }            
            if (!bManager.iniciou)
            {
                telaInicial.SetActive(false);
                bManager.iniciou = true;
                bManager.transform.SetParent(null);
                bManager.rb.gravityScale = 1;
                bManager.rb.AddForce(Vector2.up * 60, ForceMode2D.Impulse);                
            }
        }
    }
    void moveTouch()
    {
        Touch t = Input.GetTouch(0);
        Vector3 pos = Camera.main.ScreenToWorldPoint(t.position);
        pos.z = 0;
        pos.y = -3.8f;
        transform.position = pos;
    }

}
