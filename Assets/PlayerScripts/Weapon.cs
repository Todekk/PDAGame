
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "Weapon")]

public class Weapon : ScriptableObject
{

    
    public Sprite currentWeaponSpr;
    


    public GameObject bulletPrefab;
    public float fireRate = 1;
    public int damage = 20;
   

    public void Shoot()
    {

        
        GameObject bullet = Instantiate(bulletPrefab, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
        
        

    }
}
