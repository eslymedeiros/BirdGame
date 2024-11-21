using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveBasics : MonoBehaviour
{

    private Rigidbody2D rig;
    public float speed;
    public float Forca;
    public bool Jumping = false;
    public bool chao;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }


    public void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.tag == "Chao")
        {
            chao = true;
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        if (Jumping == false)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * speed;

            float input = Input.GetAxis("Horizontal");

            if (input > 0)
            {
                transform.eulerAngles = new Vector2(0f, 0f);
            }
            if (input < 0)
            {
                transform.eulerAngles = new Vector2(0f, 180f);
            }
            
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && chao && !Jumping)
        {
            rig.AddForce(new Vector2(0f, Forca), ForceMode2D.Impulse);
            chao = false;
            Jumping = true;

        }
        else
        {
            Jumping = false;
        }
    }
}    
