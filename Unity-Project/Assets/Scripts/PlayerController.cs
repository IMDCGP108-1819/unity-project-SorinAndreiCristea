using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private Animator anim;
    private Rigidbody2D player_rigidbody;

    // Start is called before the first frame update
    void Start()

    {
        anim = GetComponent<Animator>();
        player_rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            player_rigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed , player_rigidbody.velocity.y);
        }

        if(Input.GetAxisRaw("Horizontal")<0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            player_rigidbody.velocity = new Vector2(0f, player_rigidbody.velocity.y);
        }

        anim.SetFloat("Move", Input.GetAxisRaw("Horizontal"));
    }

    

}
