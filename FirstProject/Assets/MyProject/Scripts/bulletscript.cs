using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody Bullet;
    private int damage = 25;
    private int powerdamage = 30;
    private bool hitplayer = false;
    private bool trigger;

    void Start()
    {
        Bullet.GetComponent<Rigidbody>();
    }

    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player1"&& TurnManagerScript.instance.playerbuff==true)
        {

            //hitplayer = true;
            TurnManagerScript.instance.HPtext1.text =
                "Player 1's HP: " + TurnManagerScript.instance.SubtractHPpone(powerdamage);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player1" && TurnManagerScript.instance.playerbuff==false)
        {

            //hitplayer = true;
            TurnManagerScript.instance.HPtext1.text =
                "Player 1's HP: " + TurnManagerScript.instance.SubtractHPpone(damage);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Player2"&& TurnManagerScript.instance.playerbuff==false)
        {
            
                TurnManagerScript.instance.HPtext2.text =
                    "Player 2's HP: " + TurnManagerScript.instance.SubtractHPptwo(damage);
                Destroy(gameObject); 
            
        }
        if (other.gameObject.tag == "Player2"&& TurnManagerScript.instance.playerbuff==true)
        {
            
            TurnManagerScript.instance.HPtext2.text =
                "Player 2's HP: " + TurnManagerScript.instance.SubtractHPptwo(powerdamage);
            Destroy(gameObject); 
            
        }
        

        Destroy(gameObject);



    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
