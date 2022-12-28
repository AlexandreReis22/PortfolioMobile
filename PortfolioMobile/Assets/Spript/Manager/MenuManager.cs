using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void fase1()
   {
        SceneManager.LoadScene("SampleScene");
   }
   public void fase2()
   {
        SceneManager.LoadScene("fase2");
   }
    public void fase3()
    {
        SceneManager.LoadScene("fase3");
    }
    public void quit()
    {
        Application.Quit();
    }
}
