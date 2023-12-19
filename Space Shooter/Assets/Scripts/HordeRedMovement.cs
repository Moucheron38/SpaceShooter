using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordeRedMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject pointC;
    public GameObject pointD;
    private Transform currentPoint;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointD.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointD.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointD.transform)
        {
            currentPoint = pointC.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointC.transform)
        {
            currentPoint = pointD.transform;
        }
    }
}
