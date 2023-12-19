using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMissileCol : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {

            Destroy(this.gameObject);





        }

        if (col.gameObject.CompareTag("Box"))
        {

            Destroy(this.gameObject);
        }



    }
}
