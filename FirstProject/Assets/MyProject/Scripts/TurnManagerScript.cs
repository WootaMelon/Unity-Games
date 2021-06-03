using System;
using System.Collections;
using System.Collections.Generic;
using UnityChan;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TurnManagerScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    public static TurnManagerScript instance;
    public GameObject player1, player2;
    private int pselector;
    public int HP=100;
    public int HP2=100;
    public Text HPtext1;
    public Text HPtext2;
    public GameObject Panel;

    public GameObject winmessage;
    public GameObject infopanel;
    public bool playerbuff = false;
    public bool getbuff;
    public bool getpowerup;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        pselector= Random.Range(0,2);
        PlayerSwitch();
       HPtext1.text = "Player 1 HP: "+HP;
       HPtext2.text = "Player 2 HP: "+HP2;
       Panel.SetActive(false);
      winmessage.SetActive(false);
    infopanel.SetActive(true);
   player1.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
   player1.GetComponent<ShootScript>().enabled = false;
   player2.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
   player2.GetComponent<ShootScript>().enabled = false;
    }

    void Displaywinmessage()
    {
        if (HP <= 0)
        {
            Panel.SetActive(true);
            winmessage.GetComponent<Text>().text = "Player 2 Wins!";
            winmessage.SetActive(true);
        }

        if (HP2 <= 0)
        {
            Panel.SetActive(true);
            winmessage.GetComponent<Text>().text = "Player 1 Wins!";
            winmessage.SetActive(true);
        }
        
    }

    public int SubtractHPpone(int x)
    {
        HP -= x;
            return HP;
        
    }
    public int SubtractHPptwo(int x)
    {
        HP2 -= x;
        return HP2;

    }
    public int addhpone()
    {
        HP += 50;
        return HP;
    }
    public int addhptwo()
    {
        HP2 += 50;
        return HP2 ;
    }
    // Update is called once per frame
    

    public void PlayerSwitch()
    {
        if (pselector == 0)
        {
            pselector = 1;
            
            player1.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            player2.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = true;
            player1.GetComponent<ShootScript>().enabled = false;
            player2.GetComponent<ShootScript>().enabled = true;
            player1.GetComponent<UnityChanControlScriptWithRgidBody>().camera.SetActive(false);
            player2.GetComponent<UnityChanControlScriptWithRgidBody>().camera.SetActive(true);
            GetComponent<AudioSource>().Play();
            
        }
        else
        {
            pselector = 0;
            player2.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            player1.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = true;
            player2.GetComponent<ShootScript>().enabled = false;
           player1.GetComponent<ShootScript>().enabled = true;
            player2.GetComponent<UnityChanControlScriptWithRgidBody>().camera.SetActive(false);
            player1.GetComponent<UnityChanControlScriptWithRgidBody>().camera.SetActive(true);
            GetComponent<AudioSource>().Play();
        }
        
    }

    private void Update()
    {
        Displaywinmessage();
        if (Input.GetKeyDown(KeyCode.G))
        {
            infopanel.SetActive(false);
            if (pselector == 0)
            {
                player1.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = true;
                player1.GetComponent<ShootScript>().enabled = true;
            }
            else
            {
                player2.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = true;
                player2.GetComponent<ShootScript>().enabled = true;
            }
        }
    }
}
