using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackViking : MonoBehaviour
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
        if (attack_time <= 0)
        {
            if (Input.GetKey(KeyCode.O) || Input.GetKey(KeyCode.P))
            {
                Physics2D.OverlapCircleAll(attack_pos.position, attack_range, enemy);
                GameObject.Find("jeans").GetComponent<healthJeans>().health -= damage;
            }
            attack_time = start_attack_time;
        }
        else
        {
            attack_time -= Time.deltaTime;


        }

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attack_pos.position, attack_range);
    }
}

