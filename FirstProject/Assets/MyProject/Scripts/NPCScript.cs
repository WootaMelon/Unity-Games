using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
   // private bool getpowerup;

   // public GameObject particle;

    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
            if (other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2")
            {
                if (TurnManagerScript.instance.getpowerup == false)
                {
                    Panel.SetActive(true);
                    GetComponent<AudioSource>().Play();
                }

            }
    }


    private void OnTriggerExit(Collider other)
    {
        
       Panel.SetActive(false);
      
       

    }

    private void OnCollisionExit(Collision other)
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Panel.SetActive(false);
            TurnManagerScript.instance.getpowerup = true;
        }
    }
}
