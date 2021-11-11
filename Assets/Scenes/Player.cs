using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public int id = 1;

    [SerializeField] private Animator squareAnimator;

    private void Start()
    {
        Move();
    }

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Let the square roll");
            squareAnimator.SetTrigger("Roll");
        }
        
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Let the square Shrink");
            squareAnimator.SetTrigger("Shrink");
        }
    }

    //A function which moves the player
    private void Move()
    {
        Debug.Log("Player Speed 001" + speed);
        
        Debug.Log("Another log message");
    }
}
