using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
    [SerializeField] private float health;
    [SerializeField] private List<DamageType> resistances;
    [SerializeField] private List<DamageType> weakness;
    [SerializeField] private List<GameObject> spellList;
    private readonly DamageBonus damageBonus = new();


    public void Execute()
    {
        int randIndex = Random.Range(0, spellList.Count);
        Magic magic = spellList[randIndex].GetComponent<Magic>();

        if (magic.isUseOnOpponent)
        {
            magic.Execute(gameObject, GameObject.Find("Player"));
        }
        else
        {
            magic.Execute(gameObject, gameObject);
        }
    }

    public void Damage(float damageAmount, DamageType damageType)
    {
        Debug.Log("Enemy Received Damage");

        // Deal damage
        health -= damageAmount * damageBonus.GetBonus(resistances, weakness, damageType);

        // Check health < 0 then die
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
