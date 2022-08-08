using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BehaviourAI : ScriptableObject
{
    public abstract void Think(EnemyThinker thinker);
}
