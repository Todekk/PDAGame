using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Transform target;
    public string enemyTarget;
    public float moveSpeed;
    private Rigidbody2D rb;
    private Vector2 movement;
    // Start is called before the first frame update\
    void Awake()
    {
        
        rb = this.GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag(enemyTarget).transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;
            //direction.Normalize();
            movement = direction;
        }

        
    }
    private void FixedUpdate()
    {
        if (target)
        {
            rb.velocity = new Vector2(movement.x, movement.y) * moveSpeed;
        }
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
