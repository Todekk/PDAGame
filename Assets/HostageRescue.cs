using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostageRescue : MonoBehaviour
{
    public HostageRescueCounter hostageRescueCounter;
    private bool playerInZone;
    // Start is called before the first frame update
    void Start()
    {
        playerInZone = false;
        hostageRescueCounter = GameObject.Find("PLAYERUI").GetComponent<HostageRescueCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && playerInZone)
        {                       
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            playerInZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            playerInZone = false;
        }
    }
    private void OnDestroy()
    {
        hostageRescueCounter.RescueCounter();
    }
}
