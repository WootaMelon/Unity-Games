using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class HPBuffscript : MonoBehaviour
{
    public GameObject Panel;
//    private bool getbuff;
    void Start()
    {
        Panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TurnManagerScript.instance.getbuff == false)
        {
            Panel.SetActive(true);
            if (other.gameObject.tag == "Player1")
            {
                TurnManagerScript.instance.HPtext1.text =
                    "Player 1's HP: " + TurnManagerScript.instance.addhpone();
        

            }

        /*    if (other.gameObject.tag == "Player2")
            {
                TurnManagerScript.instance.HPtext2.text =
                    "Player 2's HP: " + TurnManagerScript.instance.addhptwo();

            }*/
        }
    }


    private void OnTriggerExit(Collider other)
    {
        
        Panel.SetActive(false);
        TurnManagerScript.instance.getbuff  = true;


    }

    private void OnCollisionExit(Collision other)
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
