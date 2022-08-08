using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private AudioSource gunShot;
    private Vector2 dir;
    public int damage;
        public Rigidbody2D rb;

    void Start()
    {
        gunShot = GetComponent<AudioSource>();
        gunShot.Play();
        dir = GameObject.Find("Dir").transform.position;
        transform.position = GameObject.Find("FirePoint").transform.position;
    }

    void Update()
    {        
        transform.position = Vector2.MoveTowards(transform.position, dir, speed * Time.deltaTime);
        Destroy(gameObject, 0.75f);
        
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Enemy")
        {
            enemyhealth enemy = hitInfo.GetComponent<enemyhealth>();
            enemy.TakeDamage(damage);
            /*if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }*/
            Debug.Log(hitInfo.name);

            NextGoalTrigger trigger = hitInfo.GetComponent<NextGoalTrigger>();
            if (trigger != null)
            {
                trigger.TakeDamage(damage);
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if(collision.gameObject.TryGetComponent<enemyhealth>(out enemyhealth enemyComponent))
        {
            enemyComponent.TakeDamage(damage);
        }
        Debug.Log(collision.name);*/

        //ScreenShakeController.instance.StartShake(.5f, .008f);

        Destroy(gameObject, 0.4f);
    }
}

