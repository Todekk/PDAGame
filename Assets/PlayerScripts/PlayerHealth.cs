using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text healthDisplay;
    public int health;
    public GameObject gameEndScreen;

    public void PlayerDamage(int enemydamage)
    {
        health -= enemydamage;
        if (health <= 0)
        {            
            PlayerDie();
        }
    }

    void PlayerDie()
    {        
        
        bool isActive = gameEndScreen.activeSelf;
        gameEndScreen.SetActive(!isActive);
        Destroy(gameObject, 0.3f);
    }
    void Start()
    {
        PlayerHealth health = GetComponent<PlayerHealth>();

    }
    void Update()
    {
        healthDisplay.text = "Health: " + health;
    }

}

