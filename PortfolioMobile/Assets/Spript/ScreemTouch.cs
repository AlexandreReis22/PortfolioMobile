using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreemTouch : MonoBehaviour
{
    public BolinhaManager bManager;
        
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if(t.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x, (float)-3.8f, transform.position.z);
                transform.position += (Vector3)t.deltaPosition/300;                
            }
            if (!bManager.iniciou)
            {
                bManager.iniciou = true;
                bManager.transform.SetParent(null);
                bManager.rb.AddForce(Vector2.up * 50, ForceMode2D.Impulse);
            }
        }
    }
}
