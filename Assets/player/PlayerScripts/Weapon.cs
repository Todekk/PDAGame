
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "Weapon")]

public class Weapon : ScriptableObject
{

    
    public Sprite currentWeaponSpr;
    


    public GameObject bulletPrefab;
    public float fireRate;
    public int damage;
   

    public void Shoot()
    {

        
        GameObject bullet = Instantiate(bulletPrefab, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
        
        

    }
}
