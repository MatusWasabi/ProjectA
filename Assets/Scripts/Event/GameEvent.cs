using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> _listeners = new List<GameEventListener>();

    public void RegisterListener(GameEventListener listener)
    {
        _listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        _listeners.Remove(listener);
    }

    public void Raise(Component sender, object data)
    {
        foreach (var listener in _listeners)
        {
            listener.OnEventRaised(sender, data);
        }
    }
}
