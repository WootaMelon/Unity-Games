using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battlescript : MonoBehaviour
{
    private bool loop = true;

    private bool getpowers = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        


            if (other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2")
            {

                GetComponent<AudioSource>().Play();

            }

            if (other.gameObject.tag == "Player2")
            {
                if (TurnManagerScript.instance.HP==150&& getpowers==true)
                {
                    TurnManagerScript.instance.HPtext2.text =
                        "Player 2's HP: " + TurnManagerScript.instance.addhptwo();
                }

                
            }
        
        
    }
    private void OnTriggerExit(Collider other)
    {
    if(other.gameObject.tag=="Player2")
        getpowers = false;



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
