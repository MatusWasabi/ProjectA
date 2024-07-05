using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyGang : ScriptableObject
{
    public List<GameObject> enemyGang;
    private readonly Vector3[] spawnPos = {
        new(1.7f, 0.5f, 0f),
        new(3.5f, 1.6f, 0f),
        new(3.5f, -0.6f, 0f)};

    public void Spawn()
    {
        for (int i = 0; i < enemyGang.Count; i++)
        {
            Instantiate(enemyGang[i], spawnPos[i], Quaternion.Euler(0, 0, 0));
        }
    }
}
