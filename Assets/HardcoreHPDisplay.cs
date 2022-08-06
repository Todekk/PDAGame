using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardcoreHPDisplay : MonoBehaviour
{
    public PlayerHealth playerTracker;
    public GameObject firstPhase;
    public GameObject secondPhase;
    public GameObject thirdPhase;
    public GameObject dead;
    public GameObject ammoEquipDisplay;
    // Start is called before the first frame update
    void Start()
    {
        HPDisplayer();
        AmmoDisplayer();
    }

    // Update is called once per frame
    void Update()
    {
        HPDisplayer();
        AmmoDisplayer();
    }
    public void HPDisplayer()
    {
        if(playerTracker.health > 75)
        {
            firstPhase.SetActive(false);
            secondPhase.SetActive(false);
            thirdPhase.SetActive(false);

        }
        if(playerTracker.health <= 75)
        {
            firstPhase.SetActive(true);
            secondPhase.SetActive(false);
            thirdPhase.SetActive(false);
        }
        if (playerTracker.health <= 50)
        {
            firstPhase.SetActive(false);
            secondPhase.SetActive(true);
            thirdPhase.SetActive(false);
        }
        if (playerTracker.health <= 25)
        {
            firstPhase.SetActive(false);
            secondPhase.SetActive(false);
            thirdPhase.SetActive(true);
        }
        if (playerTracker.health <= 0)
        {
            thirdPhase.SetActive(false);
            dead.SetActive(true);
        }
    }
    public void AmmoDisplayer()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            ammoEquipDisplay.SetActive(true);

        }
        else
        {
            ammoEquipDisplay.SetActive(false);
        }
       
    }
}
