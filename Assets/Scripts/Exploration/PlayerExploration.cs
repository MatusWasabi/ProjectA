using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Serialization;
using DG.Tweening;
using Vector2 = UnityEngine.Vector2;

//Move player to the position
public class PlayerExploration : MonoBehaviour
{
    [SerializeField] private Vector2 target;
    public SoPlayerData soPlayerData;

    private void Awake()
    {
        gameObject.transform.position = soPlayerData.GetMapPosition();
    }

    public void MoveTo()
    {
        target = soPlayerData.GetTargetPosition();
        if (soPlayerData.GetPossibleNodes().Contains(target))
        {
            transform.DOMove(target, 1);
        }
    }
}
