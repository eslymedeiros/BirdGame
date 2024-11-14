using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform player;
    public float MinX, MaxX;
    private void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, player.position, 0.1f);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, MinX,MaxX),transform.position.y,transform.position.z);
    }
}
