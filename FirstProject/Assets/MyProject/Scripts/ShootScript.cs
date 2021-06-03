using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
   // public int Speed;
  
    
    public GameObject bullet;
    //private int damage= 25;
    //private int powerupdmg=0;
    public GameObject orb;
    public GameObject ParticleSys;
    private bool hitplayer = false;
    private bool trigger=false;
    
    // Start is called before the first frame update
    private void Start()
    {
      ParticleSys.SetActive(false);
      bullet.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PowerUpTrigger")
        {
            if(gameObject.tag=="Player1")
            TurnManagerScript.instance.playerbuff = true;


            
                trigger = true;
                
        }
    }

  /*  private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player1")
        {
           
            hitplayer = true;
            TurnManagerScript.instance.HPtext1.text =
                "Current HP: " + TurnManagerScript.instance.SubtractHPpone(powerupdmg).ToString();
            Destroy(bullet);
        }

        if (other.gameObject.tag == "Player2")
            {
                TurnManagerScript.instance.HPtext1.text =
                    "Current HP: " + TurnManagerScript.instance.SubtractHPptwo(damage).ToString();
                Destroy(bullet);
            }
        
            Destroy(bullet);

        
        
    }*/

    // Update is called once per frame
    void Update()
    {
        if (trigger == true && Input.GetKeyDown(KeyCode.F))
        {
            
            ParticleSys.SetActive(true);
           
        }

        
            
        
        // transform.Rotate(Speed * Input.GetAxis("Vertical") * Time.deltaTime,
        //  Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);
         
        //this.transform.position+=new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))*(Speed*Time.deltaTime);
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(bullet.GetComponent<Rigidbody>(), orb.transform.position, transform.rotation);
           //clone = Instantiate(bullet.GetComponent<Rigidbody>(), player.transform.position, player.transform.rotation);
            // Give the cloned object an initial velocity along the current
            // object's Z axis
           clone.velocity = transform.TransformDirection(new Vector3(0,0,50));
            
        TurnManagerScript.instance.PlayerSwitch();
            //clone.AddForce(bullet.transform.position*100);
            
        }
    }

    
}
