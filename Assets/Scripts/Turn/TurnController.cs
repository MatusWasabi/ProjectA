 using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;


public class TurnController : MonoBehaviour
{
    [FormerlySerializedAs("thisTurn")] [SerializeField] private TurnState Turn;
    [SerializeField] private GameEvent OnEndEnemyTurn;
    public enum TurnState
    {
        Player,
        Enemy,
    }

    private void Awake()
    {
        Turn = TurnState.Player;
    }

    public void EndPlayerTurn()
    {
        Turn = TurnState.Enemy;
    }

    public void EndEnemyTurn()
    {
        Turn = TurnState.Player;
        OnEndEnemyTurn.Raise(this, Turn);
    }
}
