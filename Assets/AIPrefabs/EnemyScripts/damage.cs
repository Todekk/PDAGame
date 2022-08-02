using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    
    public int enemydamage = 40;
    

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth Player = hitInfo.GetComponent<PlayerHealth>();
        if (Player != null)
        {
            Player.PlayerDamage(enemydamage);
        }
        
        

    }
}

