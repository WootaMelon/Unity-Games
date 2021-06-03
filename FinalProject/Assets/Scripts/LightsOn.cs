using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOn : MonoBehaviour
{
    public GameObject InteractLight;

    public GameObject Lightsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            InteractLight.SetActive(true);
           
           
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Lightsound.GetComponent<AudioSource>().Play();
            InteractLight.SetActive(false);
            Destroy(gameObject);
        }
    }
}
