using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    int puan;
    int puan2;
    void Start()
    {

    }

    void Update()
    {
        if (puan == 3)
        {
            Destroy(GameObject.FindGameObjectWithTag("kapi"));
        }

        if (puan2 == 3)
        {
            Destroy(GameObject.FindGameObjectWithTag("kapi2"));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "destroyobject")
        {
            Destroy(other.gameObject);
            puan++;
        }

        if (other.gameObject.tag == "destroyobject2")
        {
            Destroy(other.gameObject);
            puan2++;

        }
    }
}
