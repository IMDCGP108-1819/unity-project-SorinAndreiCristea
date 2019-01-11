using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    public int number_of_hearts;

    public Image[] hearts;
    public Sprite full;
    public Sprite empty;

    private void Update()
    {
        if (health > number_of_hearts)
        {
            //Makes sure health doesn't exceeed a set maximum
            health = number_of_hearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                // Changes the sprite from the full heart to the empty one 
                hearts[i].sprite = full;
            }
            else
            {
                hearts[i].sprite = empty;
            }
            if (i < number_of_hearts)
            {
                // Disables excess hearts
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (health == 0)
        {
            //If a fighter dies the player is returned to the main menu screen, which would be great if they didn't both take damage at the same time
            SceneManager.LoadScene(0);
        }

    }
    }



