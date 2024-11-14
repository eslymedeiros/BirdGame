using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed;
    public float Jump;

    public LayerMask ground;

    public Rigidbody2D rig;
    public Collider2D col;

    bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * horizontal * MoveSpeed * Time.deltaTime);
        isGround = col.IsTouchingLayers(ground);
        if (isGround && Input.GetKeyDown(KeyCode.Space)){
            rig.AddForce(Vector2.up * Jump);
        }
    }
}
