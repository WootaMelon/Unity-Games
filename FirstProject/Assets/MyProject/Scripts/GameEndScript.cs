using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    public GameObject player2;

    void Start()
    {

    }

    void endgame()
    {
        if (TurnManagerScript.instance.HP == 0 || TurnManagerScript.instance.HP2 == 0)
        {
            player1.SetActive(false);
            player2.SetActive(false);
            
        }
    }

    // Update is called once per frame
        void FixedUpdate()
        {
        endgame();
        }
    }


