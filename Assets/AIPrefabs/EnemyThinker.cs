using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThinker : MonoBehaviour
{
    public BehaviourAI brain;

    // Update is called once per frame
    void Update()
    {
        brain.Think(this);
    }
}
