using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEOVER : MonoBehaviour
{
    public string mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(mainMenu);
        }
    }
}
