using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextLevel : MonoBehaviour
{
    private bool playerInZone;
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        playerInZone = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.G) && playerInZone)
        {
            Application.LoadLevel(levelToLoad);
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
