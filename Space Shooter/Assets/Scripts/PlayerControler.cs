using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    float speed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xAxe = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += (xAxe * speed * Time.deltaTime);
        transform.position = pos;
        float yAxe = Input.GetAxis("Vertical");
        Vector3 pos1 = transform.position;
        pos1.y += (yAxe * speed * Time.deltaTime);
        transform.position = pos1;
    }
}
