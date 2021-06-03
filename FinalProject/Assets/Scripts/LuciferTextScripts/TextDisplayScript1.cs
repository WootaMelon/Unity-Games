using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayScript1 : MonoBehaviour
{
    public float delay = 0.1f;

    public string fulltext;

    private string currenttext = "";

    public static TextDisplayScript1 instance;
    private void Awake()
    {
       
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public IEnumerator ShowText()
    {
        for (int i = 0; i <= fulltext.Length; i++)
        {
            currenttext = fulltext.Substring(0, i);
            this.GetComponent<Text>().text = currenttext;
            yield return new WaitForSeconds(0.05f);
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
