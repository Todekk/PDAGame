using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostageMissionScript : MonoBehaviour
{
    public GameObject desciplesOne;
    public GameObject desciplesTwo;
    public GameObject desciplesThree;
    public GameObject desciplesFour;
    public GameObject desciplesFive;
    private bool playerInZone;
    // Start is called before the first frame update
    void Start()
    {
        playerInZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInZone == true)
        {
            desciplesOne.SetActive(true);
            desciplesTwo.SetActive(true);
            desciplesThree.SetActive(true);
            desciplesFour.SetActive(true);
            desciplesFive.SetActive(true);
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
}
