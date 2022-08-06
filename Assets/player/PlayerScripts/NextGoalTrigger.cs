using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextGoalTrigger : MonoBehaviour
{
    
     public GameObject objective;
     public GameObject hardMode;    
    public GameObject endGoal;
     public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
        if (health <= 0)
        {
            bool isActive = objective.activeSelf;
            objective.SetActive(!isActive);
            if (!isActive)
            {
                objective.SetActive(false);
            }

        }
            if (health <= 0)
            {
                bool isActive = hardMode.activeSelf;
                hardMode.SetActive(!isActive);
                

            }
            if (health <= 0)
        {
            bool isActive = endGoal.activeSelf;
            endGoal.SetActive(!isActive);
            

        }
           

            Die();
        }
    }

    void Die()
    {
        ScreenShakeController.instance.StartShake(.5f, .04f);
        Destroy(gameObject);
    }







    /* void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {

     } */
}
