using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveableblock2 : MonoBehaviour
{
    float dirX, moveSpeed = 3f;
    public bool moveRight = true;
    void Start()
    {

    }


    void Update()
    {
        if (transform.position.x > 373f)
            moveRight = false;
        if (transform.position.x < 365f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);

    }
}


