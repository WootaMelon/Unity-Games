using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector2 moveDirection;

    private float moveSpeed;

    private void OnEnable()
    {
        Invoke("Destroy",3f);
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            HitScript.instance.subScore();
            HitScript.instance.ScoreText.text = HitScript.instance.score.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(moveDirection*moveSpeed*Time.deltaTime); 
     
    }
    
}
