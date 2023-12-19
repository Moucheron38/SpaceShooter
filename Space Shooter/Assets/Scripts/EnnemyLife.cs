using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyLife : MonoBehaviour
{
    [SerializeField]
    private float life;

    [SerializeField]
    private GameObject explosion;

    [SerializeField]
    private Transform startPos;





    public void TakeDamage(int _damage)
    {
        life -= _damage;

        if (life == 0)
        {
            GameObject missileLaunched = Instantiate(explosion, startPos.position, Quaternion.identity);
            Destroy(this.gameObject);


        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            TakeDamage(1);
     
        }
    }

        
}
