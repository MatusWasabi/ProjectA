using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Resetter : MonoBehaviour
{
    [SerializeField] private UnityEvent resetPlayerData;
    private void Awake()
    {
        resetPlayerData.Invoke();
    }
}
