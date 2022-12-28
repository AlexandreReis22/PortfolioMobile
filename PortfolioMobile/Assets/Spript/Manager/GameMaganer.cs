using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaganer : MonoBehaviour
{
    public int pontos;
    public GameObject telaFinal;
    
    void Update()
    {
        if(pontos == 70)
        {
            telaFinal.SetActive(true);
        }
    }

    public void proximaFase()
    {

    }
}
