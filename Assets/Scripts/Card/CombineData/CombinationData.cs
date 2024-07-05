using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CombinationData : ScriptableObject
{
    [SerializeField] public List<TupleData> data = new List<TupleData>();
}

[Serializable]
public class TupleData
{
    public string component;
    public GameObject product;

    public TupleData(string first, GameObject second)
    {
        component = first;
        product = second;
    }
}