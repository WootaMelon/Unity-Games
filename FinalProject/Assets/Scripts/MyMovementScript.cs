using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    private Vector2 velocity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 charecterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            charecterScale.x = -1;
        } 
        if (Input.GetAxis("Horizontal") > 0)
        {
            charecterScale.x = 1;
        }
        transform.localScale = charecterScale;
    
        velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        
        transform.Translate(velocity.x, velocity.y, 0);
    }
}
