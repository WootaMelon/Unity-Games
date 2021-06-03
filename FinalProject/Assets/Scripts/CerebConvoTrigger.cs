using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;


public class CerebConvoTrigger : MonoBehaviour
{
    public GameObject Text;

    public GameObject CerebConvo;

    
    public GameObject buttons;
    private bool Cerb = false;
    
    // Start is called before the first frame update
    void Start()
    {
       
        Text.SetActive(false);
        
        CerebConvo.SetActive(false);
       
        
    }

   
   

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Cerb")
        {
            Text.SetActive(true);
            Cerb = true;
        }

        


    }

    private IEnumerator OnCollisionExit2D(Collision2D other)
    {
        yield return new WaitForSeconds(5);
        Text.SetActive(false);
    }



   
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)&&Cerb==true)
        {
            Text.SetActive(false);
            CerebConvo.SetActive(true);
            buttons.SetActive(false);
            TextDisplayScript.instance.StartCoroutine(TextDisplayScript.instance.ShowText());
            buttons.SetActive(true);

        }

        
       

        if (Input.GetKeyDown(KeyCode.R))
        {
            CerebConvo.SetActive(false);
        }
    }
}
