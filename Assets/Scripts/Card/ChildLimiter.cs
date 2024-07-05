using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Limit the number that an Gameobject can have
// Destroy the rest
public class ChildLimiter : MonoBehaviour
{
    [SerializeField] private int maxChild;
    public static Action<Transform, int> OnChildExceed;

    private void Awake()
    {
        OnTransformChildrenChanged();
    }

    private void OnTransformChildrenChanged()
    {
        if (gameObject.transform.childCount > maxChild)
        {
            OnChildExceed.Invoke(gameObject.transform, maxChild);
        }
    }
}
