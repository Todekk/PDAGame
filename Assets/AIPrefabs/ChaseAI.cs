using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Brains/Chase")]
public class ChaseAI : BehaviourAI
{
    public string targetTag;
    public override void Think(EnemyThinker thinker)
    {
        GameObject target = GameObject.FindGameObjectWithTag(targetTag);
        if(target)
        {
            //var movement = thinker.gameObject.GetComponent<Enemy>
        }
    }
}
