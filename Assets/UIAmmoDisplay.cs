using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIAmmoDisplay : MonoBehaviour
{
    public PlayerMovement weapon;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        UpdateAmmoText();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAmmoText();
        
    }
    public void UpdateAmmoText()
    {
        text.text = $"{weapon.currentWeapon.currentClip}/{weapon.currentWeapon.maxClipSize}| {weapon.currentWeapon.currentAmmo}";
        if(weapon.currentWeapon.currentClip == 0)
        {
            text.color = Color.yellow;


            if (weapon.currentWeapon.currentAmmo == 0 && weapon.currentWeapon.currentClip == 0)
            {
                text.color = Color.red;
            }
        }
        if(weapon.currentWeapon.currentClip > 0)
        {
            text.color = new Color(111, 111, 111);
        }
        

    }
}
