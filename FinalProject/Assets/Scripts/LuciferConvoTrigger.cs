using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;


public class LuciferConvoTrigger : MonoBehaviour
{
    public GameObject Text;

    public GameObject LuciferConvo;

    
    public GameObject buttons;
    private bool Lucifer = false;
    
    // Start is called before the first frame update
    void Start()
    {
       
        Text.SetActive(false);
        
        LuciferConvo.SetActive(false);
       
        
    }

   
   

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Lucifer")
        {
            Text.SetActive(true);
            Lucifer = true;
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
        if (Input.GetKeyDown(KeyCode.L)&&Lucifer==true)
        {
            Text.SetActive(false);
            LuciferConvo.SetActive(true);
            buttons.SetActive(false);
            TextDisplayScript1.instance.StartCoroutine(TextDisplayScript1.instance.ShowText());
            buttons.SetActive(true);

        }

        
       

        if (Input.GetKeyDown(KeyCode.R))
        {
            LuciferConvo.SetActive(false);
        }
    }
}