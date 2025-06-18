using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //public variable - setting public preset speed for character movement
    public float speed = 1;
    //private variable
    private Rigidbody2D physicsBody = null;

    //setting rigid body for player
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    //when player moves joystick left, move character left
    public void MoveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = -speed;
        physicsBody.velocity = newVelocity;
    }

    //when player moves joystick right, move character right
    public void MoveRight()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.x = +speed;
        physicsBody.velocity = newVelocity;
    }

    //setting public preset jump speed for character
    public float jumpSpeed = 10;

    //when player presses button, make them jump
    public void Jumping()
    {
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.y = jumpSpeed;
        physicsBody.velocity = newVelocity;
    }

}
