using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData")]
public class SoPlayerData : ScriptableObject, IMapData
{
    [SerializeField] private SoPlayerData dataReset; 
    [FormerlySerializedAs("_mapPosition")][SerializeField] private Vector2 mapPosition;
    [FormerlySerializedAs("nextNode")][FormerlySerializedAs("_nextNode")][SerializeField] private Vector2 targetNode;
    [SerializeField] private List<Vector2> possibleNodes;
    public EnemyGang enemyGang;
    [SerializeField] private GameEvent OnHealthChange;

    [FormerlySerializedAs("_health")][SerializeField] private int health;
    [FormerlySerializedAs("_deck")][SerializeField] private List<Card> deck;


    public void Reset()
    {
        mapPosition = dataReset.mapPosition;
        targetNode = dataReset.targetNode;
        possibleNodes = dataReset.possibleNodes;
        enemyGang = dataReset.enemyGang;
        health = dataReset.health;
        deck = dataReset.deck;
    }

    public Vector2 GetTargetPosition()
    {
        return targetNode;
    }

    public Vector2 GetMapPosition()
    {
        return mapPosition;
    }

    public void SetMapPosition(Vector2 newMapPosition)
    {
        mapPosition = newMapPosition;
    }

    public void SetTargetNode(Vector2 location)
    {
        targetNode = location;
    }

    public List<Vector2> GetPossibleNodes()
    {
        return possibleNodes;
    }

    public void SetPossibleNodes(List<Vector2> newPossibleNodes)
    {
        possibleNodes = newPossibleNodes;
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int newHealth)
    {
        health = newHealth;
        OnHealthChange.Raise(new Component(), newHealth);
    }

    public List<Card> GetDeck()
    {
        return deck;
    }

    public void SetDeck(List<Card> newDeck)
    {
        deck = newDeck;
    }
}

public interface ICombatData
{
    public int GetHealth();
    public void SetHealth(int newHealth);
    public List<Card> GetDeck();
}

public interface IMapData
{
    public Vector2 GetMapPosition();
    public void SetMapPosition(Vector2 position);
    public Vector2 GetTargetPosition();
    public List<Vector2> GetPossibleNodes();
    public void SetPossibleNodes(List<Vector2> possibleNodes);
}

