using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HitScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static HitScript instance;
    public Text ScoreText;
    public int score=15;
   
    
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
       
        ScoreText.text = score.ToString();
    }
    public void subScore()
    {
        score--;
        ScoreText.text = score.ToString();
    }

    
    // Update is called once per frame
    void Update()
    {
        if (score == 0)
        {
            Application.Quit();
        }
    }
}
