using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int explosionradius = 5;

    private Collider[] colliders;
    void Start()
    {
        
            
        }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "bullet")
        {
            colliders = Physics.OverlapSphere(transform.position, explosionradius);

            foreach (Collider c in colliders)
            {


                if (c.gameObject.tag == "Obstacle")
                {
                    if (c.gameObject.GetComponent<Rigidbody>())
                    {
                        c.gameObject.GetComponent<Rigidbody>().AddExplosionForce(500, transform.position, 20);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,explosionradius);
    }
}
