using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Choix_IA()
    {
        SceneManager.LoadScene(6);
    }

    public void MenuChoix()
    {
        SceneManager.LoadScene(3);
    }

    public void Options()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadMenu()
    {
         Debug.Log("Loading Game...");
         Time.timeScale = 1f;
         SceneManager.LoadScene(0);
    }

    public void Quitter()
    {
        Debug.Log("QUITTER");
        Application.Quit();
    }
}
