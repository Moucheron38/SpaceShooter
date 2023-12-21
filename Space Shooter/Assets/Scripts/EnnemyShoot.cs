using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject Missile;

    [SerializeField]
    private Transform startPos;

    [SerializeField]
    private Vector2 vitesse;

    [SerializeField]
    private float timer;

    [SerializeField]
    private AudioClip lazer;

    [SerializeField]
    private AudioSource source;



    private void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            shoot();
            source.PlayOneShot(lazer);

        }
    }



    void shoot()
    {
        GameObject missileLaunched = ObjectPooler.GetInstance(Missile);
        missileLaunched.transform.position = startPos.position;
        missileLaunched.transform.rotation = Quaternion.identity;
        Rigidbody2D rb2 = missileLaunched.GetComponent<Rigidbody2D>();
        rb2.AddForce(vitesse);

    }
    
}
