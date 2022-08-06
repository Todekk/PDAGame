using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HostageRescueCounter : MonoBehaviour
{
    public Text hostagesRescued;
    public int hostageRescues = 0;
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        ShowRescueCounter();
    }

    // Update is called once per frame
    void Update()
    {
        ShowRescueCounter();
        RescueEveryone();
    }
    public void ShowRescueCounter()
    {
        hostagesRescued.text = $"Hostages rescued:{hostageRescues}";
    }
    public void RescueCounter()
    {
        hostageRescues++;
    }
    public void RescueEveryone()
    {
        if(hostageRescues == 8)
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}
