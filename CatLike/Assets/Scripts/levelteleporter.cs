using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class levelteleporter : MonoBehaviour
{
    public Slider slider;
    public int health;
    public bool dead = false;
    public GameObject story2;
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    void Update()
    {

    }

    void Damage()
    {
        health -= 1;
        slider.value = health;
        AmIDead();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "akvaryum")
        {
            FindObjectOfType<AudioManager>().Play("splash");
            Debug.Log("splash");
            StartCoroutine(Delay());
            Damage();
        }

        else if (collision.gameObject.tag == "zemin")
        {
            StartCoroutine(Delay());
            Damage();
        }

        else if (collision.gameObject.tag == "camsise")
        {
            transform.position = GameObject.FindGameObjectWithTag("spawn2").transform.position;
            Damage();
        }

        else if (collision.gameObject.tag == "rogar")
        {
            transform.position = GameObject.FindGameObjectWithTag("spawn2").transform.position;
            Damage();
        }

        else if (collision.gameObject.tag == "doge")
        {
            transform.position = GameObject.FindGameObjectWithTag("spawn2").transform.position;
            Damage();
        }

        else if (collision.gameObject.tag == "level1finish")
        {
            transform.position = GameObject.FindGameObjectWithTag("spawn2").transform.position;
            story2.SetActive(true);

        }

        else if (collision.gameObject.tag == "level2finish")
        {
            SceneManager.LoadScene(3);
        }

    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.4f);
        transform.position = GameObject.FindGameObjectWithTag("spawn").transform.position;
    }
    IEnumerator Delay2()
    {
        yield return new WaitForSeconds(0.4f);
        transform.position = GameObject.FindGameObjectWithTag("spawn").transform.position;
    }



    void AmIDead()
    {
        if (health <= 0)
        {
            dead = true;
            Time.timeScale = 1;
            SceneManager.LoadScene(2);
        }
    }
}
