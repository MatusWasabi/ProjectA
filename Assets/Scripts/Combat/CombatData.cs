using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatData : MonoBehaviour, ICombatData
{
    [SerializeField] private SoPlayerData soPlayerData;
    public int GetHealth()
    {
        return soPlayerData.GetHealth();
    }

    public void SetHealth(int newHealth)
    {
        soPlayerData.SetHealth(newHealth);
    }

    public List<Card> GetDeck()
    {
        return soPlayerData.GetDeck();
    }
}
