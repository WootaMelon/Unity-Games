using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CandyDetector : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject candyinteract;
    public GameObject surprise;
    public GameObject reset;
    private bool collided=false;
    void Start()
    {
        
        surprise.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            candyinteract.SetActive(true);
            collided = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            surprise.SetActive(true);
        }

        if (Input.GetMouseButton(0) && collided == true) 
        {
            reset.SetActive(true);
            
        }
    }
}
