using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Accuire card
public class CardNode : MapNode
{
    [SerializeField] private List<CombinationData> newCards;
    [SerializeField] private GameEvent OnPlayerKnowNewCard;
    public override void Execute(Collider2D other)
    {
        ICombatData icombatData = other.GetComponent<ICombatData>();
        List<Card> deck = icombatData.GetDeck();
        OnPlayerKnowNewCard.Raise(this, newCards);
    }
}
