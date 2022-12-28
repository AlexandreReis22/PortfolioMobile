using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject MenuGameOver;
    public BolinhaManager bManager;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("bloquinho"))
        {              
            MenuGameOver.SetActive(true);
            Time.timeScale = 0;
            bManager.iniciou = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("bolinha"))
        {
            MenuGameOver.SetActive(true);
            Time.timeScale = 0;
            bManager.iniciou = false;
        }
    }

    public void reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
