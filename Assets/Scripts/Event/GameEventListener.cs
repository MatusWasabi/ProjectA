using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[System.Serializable]
public class DynamicUnityEvent : UnityEvent<Component, object> {}
public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;

    public DynamicUnityEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(Component sender, object data)
    {
        Response.Invoke(sender, data);
    }
}
