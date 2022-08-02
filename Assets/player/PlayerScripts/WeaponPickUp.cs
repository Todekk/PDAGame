using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public Weapon weapon;
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            target.GetComponent<PlayerMovement>().currentWeapon = weapon;
            target.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = weapon.currentWeaponSpr;
            Destroy(gameObject);
        }
    }
}
