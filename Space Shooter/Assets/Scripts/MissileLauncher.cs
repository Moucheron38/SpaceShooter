using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    [SerializeField] 
    private GameObject Missile;

    [SerializeField]
    private Transform startPos;

    [SerializeField]
    private Vector2 vitesse;

    [SerializeField]
    private AudioClip shoot;

    [SerializeField]
    private AudioSource source;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject missileLaunched = Instantiate(Missile, startPos.position, Quaternion.identity);
            Rigidbody2D rb2 = missileLaunched.GetComponent<Rigidbody2D>();
            rb2.AddForce(vitesse);
            source.PlayOneShot(shoot);
        }
    }
}
