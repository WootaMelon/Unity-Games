using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSwitcherScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject judgement;
    public GameObject finalpanel;
    void Start()
    {
        judgement.GetComponent<FireBullets>().enabled = true;
        StartCoroutine(switchscript());
        StartCoroutine(selfdestruct());
    }
public IEnumerator switchscript()
{
    yield return new WaitForSeconds(10);
    judgement.GetComponent<FireBullets>().enabled = false;
    judgement.GetComponent<FireBulletsSpiral>().enabled = true;
    
}

public IEnumerator selfdestruct()
{
    yield return new WaitForSeconds(30);
    Destroy(gameObject);
    finalpanel.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
