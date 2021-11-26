using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private LayerMask whatIsGround;
    private WaitForSecondsRealtime _waitForSeconds = new WaitForSecondsRealtime(3);

    private void Start()
    {
        //StartCoroutine(CustomUpdate());
        StartCoroutine(CustomUpdate(2f));
    }

    private void Update()
    {
        //if (Time.frameCount % 100 == 0)
        {
            //MyRaycast();
        }
    }

    private void MyRaycast()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, 1, whatIsGround);
        Debug.DrawRay(transform.position, -transform.up * 1);
        if (hit.collider == null)
        {
            return;
        }

        Debug.Log($"I hit object {hit.collider.name}");
    }

    private IEnumerator MyRoutine()
    {
        Debug.Log("Hello from Couroutine!");
        yield return StartCoroutine(MyRoutine1());
        Debug.Log("Ok I waited 3 seconds");
        yield return null;
        Debug.Log("Hi");
    }
    
    private IEnumerator MyRoutine1()
    {
        Debug.Log("Hello from Couroutine1!");
        yield return _waitForSeconds;
        Debug.Log("Ok I waited 3 seconds1");
    }

    private IEnumerator CustomUpdate(float gaptime)
    {
        while (true)
        {
            Debug.Log("Hello");
            yield return new WaitForSeconds(gaptime);
        }
    }
}
