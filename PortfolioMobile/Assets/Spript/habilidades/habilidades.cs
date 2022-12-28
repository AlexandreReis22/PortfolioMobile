using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habilidades : MonoBehaviour
{
    public int idHabilidade = -1;
    public GameObject habilidade0;    

    void Start()
    {
        
    }
    
    void Update()
    {
        switch (idHabilidade)
        {
            case 0:
                Vector2 pos = transform.position;
                Instantiate(habilidade0);
                idHabilidade = -1;                
                break;
        } 
    }
}
