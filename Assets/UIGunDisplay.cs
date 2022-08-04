using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGunDisplay : MonoBehaviour
{
    public Image image;
    public PlayerMovement weapon;
    // Start is called before the first frame update
    void Start()
    {
        UpdateGunImage();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGunImage();
    }
    public void UpdateGunImage()
    {
        image.sprite = weapon.currentWeapon.currentWeaponImage;
    }
}
