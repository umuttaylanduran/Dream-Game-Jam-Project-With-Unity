using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFollower : MonoBehaviour
{
    public GameObject player;
    private float playerScale;
    void Update()
    {
        playerScale = player.transform.localScale.x;

        if (playerScale >= 0)
            transform.position = player.transform.position;
        else
        {
            transform.position = player.transform.position + new Vector3(2f, 0f, 0f);
            Debug.Log("position shifted");
        }


    }
}
