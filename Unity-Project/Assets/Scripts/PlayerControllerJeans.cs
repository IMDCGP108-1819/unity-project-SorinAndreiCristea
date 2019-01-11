using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerJeans : MonoBehaviour
{
    public float moveSpeed;

    private Animator anim;
    private Rigidbody2D player_rigidbody;
    private bool light = false;
    private bool heavy = false;

    // Start is called before the first frame update
    void Start()

    {
        anim = GetComponent<Animator>();
        player_rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            player_rigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, player_rigidbody.velocity.y);
        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            player_rigidbody.velocity = new Vector2(0f, player_rigidbody.velocity.y);
        }

        anim.SetFloat("Move", Input.GetAxisRaw("Horizontal"));

        HandleInput();
        HandleAttacks();
        ResetValues();



    }

    private void HandleAttacks()
    {
        if (light)
        {
            anim.SetTrigger("light");
        }
        if (heavy)
        {
            anim.SetTrigger("heavy");
        }
    }
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            light = true;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            heavy = true;
        }
    }
    private void ResetValues()
    {
        light = false;
        heavy = false;
    }

}

