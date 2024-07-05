using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Enemy[] allEnemies;
    [SerializeField] private GameEvent OnAllEnemyFinish;
    [SerializeField] private UnityEvent OnAllEnemyDie;

    private void Start()
    {
        allEnemies = FindObjectsOfType<Enemy>();
    }

    public void Execute()
    {
        
        allEnemies = FindObjectsOfType<Enemy>();
        if (allEnemies.Length == 0)
        {
            OnAllEnemyDie.Invoke();
        }
        foreach (var enemy in allEnemies)
        {
            enemy.Execute();
        }
        OnAllEnemyFinish.Raise(this, allEnemies);
    }
}
