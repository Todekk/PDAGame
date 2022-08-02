using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
    public float speed = 20f;
    private Vector2 dir;
    public int damage = 15;
    public Rigidbody2D rb;

    void Start()
    {
        dir = GameObject.Find("Dir").transform.position;
        transform.position = GameObject.Find("BulletPos1").transform.position;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, dir, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        enemyhealth enemy = hitInfo.GetComponent<enemyhealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Debug.Log(hitInfo.name);
        //ScreenShakeController.instance.StartShake(.5f, .008f);

        Destroy(gameObject);

    }
}

