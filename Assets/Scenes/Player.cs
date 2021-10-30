using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;

    private void Start()
    {
        Move();
    }

    //A function which moves the player
    private void Move()
    {
        Debug.Log("Player Speed 001" + speed);
        
        Debug.Log("Another log message");
    }
}
