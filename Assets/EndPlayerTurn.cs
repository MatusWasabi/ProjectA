using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlayerTurn : MonoBehaviour
{
    [SerializeField] private GameEvent onEndPlayerTurn;

    public void EndTurn()
    {
        Debug.Log("End Player Turn Call from Button");
        onEndPlayerTurn.Raise(this, TurnController.TurnState.Player);
    }
}
