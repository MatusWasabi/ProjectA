using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceedChildDestroyer : MonoBehaviour
{
    private void OnEnable()
    {
        ChildLimiter.OnChildExceed += DestroyExceedChild;
    }

    private void OnDisable()
    {
        ChildLimiter.OnChildExceed -= DestroyExceedChild;
    }

    private void DestroyExceedChild(Transform parent, int handLimit)
    {
        int numberOfChild = parent.childCount;
        for (int i = 0; i < numberOfChild; i++)
        {
            if (i >= handLimit)
            {
                Destroy(parent.GetChild(i).gameObject);
            }
        }
    }
}
