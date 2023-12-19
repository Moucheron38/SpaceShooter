using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destru", 0.3f);

        Invoke("end", 0.7f);
    }

   private void Destru()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    private void end()
    {
        Destroy(this.gameObject);
    }
}
