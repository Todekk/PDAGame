using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public string startLevel;

    public string levelSelect;

    public string controlMenu;


    public void NewGame()
    {      

        Application.LoadLevel(startLevel);
    }

    public void LevelSelect()
    {
       
        Application.LoadLevel(levelSelect);

    }
    public void ControlMenu()
    {
        
        Application.LoadLevel(controlMenu);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
