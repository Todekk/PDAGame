using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGUI : MonoBehaviour
{

    public GameObject objectiveMenu;
    public GameObject menu;
    public int pause;
    public int inGame ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OpenObjectiveMenu();
        OpenMenu();
    }

    public void OpenObjectiveMenu()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (objectiveMenu.activeSelf)
            {
                objectiveMenu.SetActive(false);
                Time.timeScale = inGame;
            }
            else
            {
                objectiveMenu.SetActive(true);
                Time.timeScale = pause;
            }
        }
    }
    public void OpenMenu()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (menu.activeSelf)
            {
                menu.SetActive(false);
                Time.timeScale = inGame;
            }
            else
            {
                menu.SetActive(true);
                Time.timeScale = pause;
            }
        }
    }
}
