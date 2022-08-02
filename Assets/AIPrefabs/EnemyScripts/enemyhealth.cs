using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public int health = 100;
    
    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            
            Die();
        }
    }

    void Die ()
    {
        ScreenShakeController.instance.StartShake(.5f, .04f);
        Destroy(gameObject);
    }
  
}
