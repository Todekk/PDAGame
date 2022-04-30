using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoScript : MonoBehaviour
{

    public GameObject videoScreen;
    public string levelSelect;
    public float waitForVideo;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if(videoScreen.activeSelf)
        {
            waitForVideo -= Time.deltaTime;
        }
        if(waitForVideo <0)
        {
            Application.LoadLevel(levelSelect);
        }
    }

    // Update is called once per frame
    
}
