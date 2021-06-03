using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgementMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed;
    private bool moveRight;
    void Start()
    {
        moveSpeed = 2f;
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -30.68f)
        {
            moveRight = false;
        }
        else if (transform.position.x > -26.68f)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
            
        }
        else
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
    }
}
