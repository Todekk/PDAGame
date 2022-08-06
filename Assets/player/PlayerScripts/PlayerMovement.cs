using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Weapon currentWeapon;
    public GameObject bullet;
    public float moveSpeed = 1.5f;
    public Rigidbody2D rb;
    public PlayerHealth playerHealth;
    private float nextTimeOfFire = 0;
    public int healthPacks = 5;
    public GameObject nightVision;
    public GameObject terrainLight;
    public GameObject nightVisionPortrait;
    

    public Camera cam;    

    Vector2 movement;
    Vector2 mousePos;
   
    // Update is called once per frame
    void Update()
    {

        //night vision
        if (Input.GetKeyDown(KeyCode.N))
        {
            if(nightVision.activeSelf == true)
            {
                nightVision.SetActive(false);
                terrainLight.SetActive(true);
                nightVisionPortrait.SetActive(false);
            }
            else
            {
                nightVision.SetActive(true);                
                terrainLight.SetActive(false);
                nightVisionPortrait.SetActive(true);
            }
        }
        //healing
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (healthPacks > 0)
            {
                playerHealth.PlayerHealing();
                healthPacks--;
            }            
        }
        //shooting
        if (Input.GetButton("Fire1"))
        {
            if(Time.time >= nextTimeOfFire)
            {
                currentWeapon.Shoot();
                nextTimeOfFire = Time.time + 1 / currentWeapon.fireRate;
            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            currentWeapon.Reload();
        }
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
       

       mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    

    void FixedUpdate()
    {
      //movement
      rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }
}
