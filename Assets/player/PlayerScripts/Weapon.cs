
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "Weapon")]

public class Weapon : ScriptableObject
{
    public Sprite currentWeaponImage;
    public Sprite currentWeaponSpr;
    public GameObject bulletPrefab;
    public float fireRate;
    public int damage;
    public int currentClip, maxClipSize, currentAmmo, maxAmmoSize;
    
    public void Shoot()
    {
        if (currentClip > 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
            currentClip--;
        }
        
        

    }
    public void Reload()
    {
        int reloadAmount = maxClipSize - currentClip; //how many bullets to refill clip
        reloadAmount = (currentAmmo - reloadAmount) >= 0 ? reloadAmount : currentAmmo;
        currentClip += reloadAmount;
        currentAmmo -= reloadAmount;
    }

    public void AddAmmo(int ammoAmount)
    {
        currentAmmo += ammoAmount;
        if(currentAmmo > maxAmmoSize)
        {
            currentAmmo = maxAmmoSize;
        }
    }
}
