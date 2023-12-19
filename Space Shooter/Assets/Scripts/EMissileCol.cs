using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMissileCol : MonoBehaviour
{
    [Tooltip("Liste contenant les tags avec lesquels la collision aura lieu")] 
    [SerializeField] List<string> tags;
    public float speed;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        foreach(string tag in tags)
        {
            if (col.gameObject.CompareTag(tag))
            {
                gameObject.SetActive(false);
                break;
            }
        }


    }
}
