using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class CombatNode : MapNode
{
    [FormerlySerializedAs("EnterCombat")][SerializeField] private UnityEvent enterCombat;
    [SerializeField] private EnemyGang enemyGang;
    public override void Execute(Collider2D other)
    {
        var soPlayerData = other.GetComponent<PlayerExploration>().soPlayerData;
        soPlayerData.enemyGang = enemyGang;
        soPlayerData.SetTargetNode(new Vector2(0, 0));
        enterCombat.Invoke();
    }
}
