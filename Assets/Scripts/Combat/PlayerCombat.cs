using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCombat : MonoBehaviour, IDamagable
{
    [SerializeField] private float health;
    [SerializeField] private SoPlayerData soPlayerData;
    [SerializeField] private List<DamageType> resistances;
    [SerializeField] private List<DamageType> weakness;
    [SerializeField] private GameEvent OnPlayerDeath;

    private readonly DamageBonus damageBonus = new();

    private void Awake()
    {
        soPlayerData.enemyGang.Spawn();
        health = soPlayerData.GetHealth();
    }

    public void Damage(float damageAmount, DamageType damageType)
    {
        Debug.Log("Player Received Damage");
        health -= damageAmount * damageBonus.GetBonus(resistances, weakness, damageType) / 10;
        soPlayerData.SetHealth(math.floor(health + 0.5).ConvertTo<int>());

        if (health <= 0)
        {
            OnPlayerDeath.Raise(this, health);
        }
    }
}
