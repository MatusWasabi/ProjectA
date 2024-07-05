using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Execute whatever it can

public abstract class MapNode : MonoBehaviour
{
    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        if ((Vector2)gameObject.transform.position == other.GetComponent<PlayerExploration>().soPlayerData.GetTargetPosition())
        {
            Execute(other);
        }
    }

    public abstract void Execute(Collider2D other);

}
