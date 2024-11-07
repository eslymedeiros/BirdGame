using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveBasics : MonoBehaviour
{

    public Rigidbody2D rig;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = Vector2.right * speed;
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = Vector2.left * speed;
            transform.eulerAngles = new Vector2(0f, 180f);
        }
        
    }
}
