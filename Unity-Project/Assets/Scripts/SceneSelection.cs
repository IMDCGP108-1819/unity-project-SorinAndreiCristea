using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
{
   public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Instructions ()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame ()
    { 
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void parking_lot ()
    {
        SceneManager.LoadScene(4);
    }
}
