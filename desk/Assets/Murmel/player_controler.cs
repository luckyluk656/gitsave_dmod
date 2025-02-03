using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class player_controler : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    [Range(0f, 20f)]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX,0f,movementY);
        rb.AddForce(movement * speed);
    }
    void OnMove(InputValue movementvalue)
    {
        Vector2 movement = movementvalue.Get<Vector2>();

        movementX = movement.x;
        movementY = movement.y;
    }
}
