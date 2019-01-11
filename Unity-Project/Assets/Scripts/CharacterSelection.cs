using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    static public bool viking_chosen = true;
    //Sets a static value to signal which character the player chooses

    public void jeans_chosen()
    {
        viking_chosen = false;
        SceneManager.LoadScene(2);
    }

    private void Awake()
    {
        //Turns off the controller script of the unchosen character when entering the stage. I'd replace it with an AI but I can't wrap my head around State Machine Behaviours
        if (viking_chosen == false)
            GameObject.Find("viking").GetComponent<PlayerController>().enabled = false;
        else
            GameObject.Find("jeans").GetComponent<PlayerControllerJeans>().enabled = false;
    }
}
