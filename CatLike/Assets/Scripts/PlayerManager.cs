using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float health;

    bool dead = false;

    public Transform damageText;

    public Slider slider;

   
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    void Update()
    {
        
    }
    
    public void GetDamage(float damage)
    {
        Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<TextMesh>().text = damage.ToString();

        if (health - damage >= 0)
        {
            health -= damage;
          
        }
        else
        {
            health = 0;
        }
        slider.value = health;
        AmIDead();
    }

    void AmIDead()
    {
        if (health <=0)
        {
            dead = true;
            Time.timeScale = 1;
            SceneManager.LoadScene(2);
        }
    }
}
