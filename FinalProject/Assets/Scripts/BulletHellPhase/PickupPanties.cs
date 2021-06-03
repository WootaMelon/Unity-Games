using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPanties : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public GameObject text;
    void Start()
    {
        panel.SetActive(false);
        text.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
          text.SetActive(true); 
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            panel.SetActive(true);
            text.SetActive(false);
            Destroy(gameObject);
        }
    }
}
