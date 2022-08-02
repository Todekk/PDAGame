using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
   public GameObject panel;

    public void OpenPanel()
    {
       
            if (panel != null)
            {
                bool isActive = panel.activeSelf;
                panel.SetActive(!isActive);
            if (!isActive  && Input.GetKeyDown(KeyCode.G))
            {
                panel.SetActive(false);
                
            }

        }
        
    }
    public void ClosePanel()
    {

        if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
            if (!isActive && Input.GetKeyDown(KeyCode.G))
            {
                panel.SetActive(false);

            }

        }

    }
    
}
