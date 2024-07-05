using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

// Healing whatever it collide
public class HealingNode : MapNode
{
    [SerializeField] private int healingAmount;
    
    public override void Execute(Collider2D other)
    {
        ICombatData icombatData = other.GetComponent<ICombatData>();
        int health = icombatData.GetHealth();
        health += healingAmount;
        icombatData.SetHealth(health);
    }
}
