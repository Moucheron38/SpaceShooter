using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject pointA;
    public GameObject pointB;
    private Transform currentPoint;
    public float speed;
    float t;
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
        } */
        Move();
    }

    void Move()
    {
        t =Mathf.Abs( Mathf.Sin(Time.time));


        float _t = Mathf.Sin(Time.time * 1f); //Retourne une valeur sinusoidal oscillant de -1 à 1
        float _tBis = Mathf.Lerp(0, 1, Mathf.InverseLerp(-1, 1, _t)); //Remap de -1 => 1 à 0 => 1

        transform.position = Vector3.Lerp(pointA.transform.position, pointB.transform.position, _tBis);

    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }


}
