using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieKillCounter : MonoBehaviour
{
    public Text killCounter;
    public int kills = 0;
    public GameObject bossSpawn;
    // Start is called before the first frame update
    void Start()
    {
        ShowKillCounter();
    }

    // Update is called once per frame
    void Update()
    {
        ShowKillCounter();
    }
    public void ShowKillCounter()
    {
        killCounter.text = $"KILLS:{kills}";
    }
    public void KillCounter()
    {
        kills++;
    }
    public void BossSpawner()
    {
        if(kills == 25)
        {
            bossSpawn.SetActive(true);
        }
    }    
}
