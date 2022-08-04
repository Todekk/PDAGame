using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthPacks : MonoBehaviour
{
    public PlayerMovement healthPackAmount;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        DisplayHealthpackAmount();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHealthpackAmount();
    }
    public void DisplayHealthpackAmount()
    {
        text.text = $"x{healthPackAmount.healthPacks}";
        
    }
}
