using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public int health = 100;
    public ZombieKillCounter zombieKillCounter;

    public void Start()
    {
        zombieKillCounter = GameObject.Find("PLAYERUI").GetComponent<ZombieKillCounter>();
    }
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
    private void OnDestroy()
    {
        zombieKillCounter.KillCounter();
    }

}
