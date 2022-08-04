using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text healthDisplay;
    public int health;
    public GameObject gameEndScreen;
    public int healAmount;    
    public GameObject playerCharacter;

    public void PlayerDamage(int enemydamage)
    {
        health -= enemydamage;
        if (health <= 0)
        {
            healthDisplay.text = "Health:0%";
            PlayerDie();
        }
    }

    public void PlayerHealing()
    {
       health += 25;
       if (health > 100)
        {
          health = 100;
        }
       
    }

    void PlayerDie()
    {     
        gameEndScreen.SetActive(true);
        playerCharacter.SetActive(false);
        //Destroy(gameObject);
    }
    void Start()
    {
        PlayerHealth health = GetComponent<PlayerHealth>();

    }
    void Update()
    {
        healthDisplay.text = "Health:" + health +"%";
        if(health < 50 && health > 25)
        {
           healthDisplay.color = Color.yellow;
        }
        if(health > 50)
        {
            healthDisplay.color = Color.white;
        }
        if(health < 25)
        {
            healthDisplay.color = Color.red;
        }
    }

}

