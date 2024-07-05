using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    public void Damage(float damageAmount, DamageType damageType);
}

public class DamageBonus
{
    public float GetBonus(List<DamageType> resistances, List<DamageType> weakness, DamageType damageType)
    {
        if (resistances.Contains(damageType))
        { return 0.5f; }
        else if (weakness.Contains(damageType))
        { return 1.5f; }
        else
        { return 1f; }
    }
}