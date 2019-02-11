using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstController : MonoBehaviour
{
    //SerializeField
    [SerializeField]
    float maxSpeed = 2f;

    //Private
    Rigidbody2D rigidBody;
    float moveX = 0f, moveY = 0f;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
            rigidBody.velocity = new Vector2(maxSpeed * moveX, maxSpeed * moveY);
    }
}
