using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public Transform bulletPos1;
    public GameObject bullet;
    private Transform playerPos;
    private Rigidbody2D rb;
    public float speed = .3f;
    private bool isInRange = false;
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, playerPos.position) > 2.5f)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
            isInRange = false;
        }

        else
        {
            isInRange = true;
            Shoot();

        }
    }

    void FixedUpdate()
    {
        Rotation();
    }

    void Rotation()
    {
        Vector2 direction = (playerPos.gameObject.GetComponent<Rigidbody2D>().position - rb.position).normalized;

         float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }
    IEnumerator Shoot()
    {
        if (isInRange)
        {
            Instantiate(bullet, bulletPos1.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(.8f);
        StartCoroutine(Shoot());
    }
}
