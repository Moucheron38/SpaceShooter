using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCol : MonoBehaviour
{
    public float speed;
   
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Enemy"))
        {
            
            Destroy(this.gameObject);

        
            


        }

        if (col.gameObject.CompareTag("Box"))
        {

            Destroy(this.gameObject);
        }



    }
}
