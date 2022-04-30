using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int maxPlayerHealth;
    public static int playerHealth;

    //Text text;
    public Slider healthBar;

    

    public bool isDead;

    
    // Start is called before the first frame update
    void Start()
    {
        //text = GetComponent<Text>();
        healthBar = GetComponent<Slider>();

        playerHealth = PlayerPrefs.GetInt("PlayerCurrentHealth");      

        
        isDead = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0 && !isDead)
        {
            playerHealth = 0;
            
            isDead = true;
        }
        //text.text = "" + playerHealth;
        healthBar.value = playerHealth;
    }
    public static void HurtPlayer(int damageToGive)
    {
        playerHealth -= damageToGive;
        PlayerPrefs.SetInt("PlayerCurrentHealth", playerHealth);
    }
    public void FullHealth()
    {
        playerHealth = PlayerPrefs.GetInt("PlayerMaxHealth");
        PlayerPrefs.GetInt("PlayerCurrentHealth");
    }
    public static void AddHealth(int healthToAdd)
    {
        playerHealth += healthToAdd;
        PlayerPrefs.SetInt("PlayerCurrentHealth", playerHealth);
    }
}