using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    public Animator animator;
    private AudioSource myAudioSource;

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        animator = gameObject.GetComponent<Animator>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "cat")
        {
            animator.SetBool("Agro", true);
            myAudioSource.Play();
        }
    }
}
