using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float health;
    public float damage;

    

    bool collliderBusy = false;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !collliderBusy)
        {
            collliderBusy = true;
            other.GetComponent<PlayerManager>().GetDamage(damage);

        }
      
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            collliderBusy = false;
        }
    }
}
