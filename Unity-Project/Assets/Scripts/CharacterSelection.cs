using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    static public bool viking_chosen = true;

    public void jeans_chosen()
    {
        viking_chosen = false;
        SceneManager.LoadScene(2);
    }

    private void Awake()
    {
        if (viking_chosen == false)
            GameObject.Find("viking").GetComponent<PlayerController>().enabled = false;
        else
            GameObject.Find("jeans").GetComponent<PlayerControllerJeans>().enabled = false;
    }
}
