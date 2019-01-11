using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private float attack_time;
    public float start_attack_time;
    public Transform attack_pos;
    public LayerMask enemy;
    public float attack_range;
    public int damage;

    // Update is called once per frame
    void Update()
    {
        //Stop the player from spamming attack or 
        if(attack_time <= 0)
        {
            //Checks if the player is attacking
            if (Input.GetKey(KeyCode.O) || Input.GetKey(KeyCode.P))
            {
                //Creates a circuar area in front of the player, checks for any overlapping colliders and deals damage if any. 
                Collider2D[] enemies = Physics2D.OverlapCircleAll(attack_pos.position, attack_range, enemy);
                for (int i = 0; i < enemies.Length; i++)
                    enemies[i].GetComponent<Health>().health -= damage;
            }
            attack_time = start_attack_time;
            }
            else
            {
                attack_time -= Time.deltaTime;
            

        }
       
    }
    //Visual representation of damage area
     void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attack_pos.position, attack_range);
    }
}
