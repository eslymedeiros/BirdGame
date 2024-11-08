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
    void FixedUpdate()
    {
        if (Jumping == false)
        {
            if (Input.GetKey(KeyCode.D) && Jumping == false)
            {
                rig.velocity = Vector2.right * speed;
                transform.eulerAngles = new Vector2(0f, 0f);

            }

            else if (Input.GetKey(KeyCode.A) && Jumping == false)
            {
                rig.velocity = Vector2.left * speed;
                transform.eulerAngles = new Vector2(0f, 180f);

            }
            else
            {
                rig.velocity = Vector2.zero;
            }
        }

        if (Input.GetKey(KeyCode.Space) && chao && Jumping == false)
        {
            rig.AddForce(Vector2.up * Forca, ForceMode2D.Impulse);
            chao = false;
            Jumping = true;
            
        }
        else
        {
            Jumping = false;
        }
        
        
    }
}
