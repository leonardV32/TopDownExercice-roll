using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ShakeEvent", menuName = "EventsSO/ShakeEvent")]

public class ShakeEvent : ScriptableObject
{
    private List<ShakeEventListener> listeners = new List<ShakeEventListener>();

    public void AddListener(ShakeEventListener newListener)
    {
        listeners.Add(newListener);
    }

    public void RemoveListener(ShakeEventListener listenerToRemove)
    {
        listeners.Remove(listenerToRemove);
    }

    public void Raise()
    {
        foreach (var eventListener in listeners)
        {
            eventListener.OnEventRaised();
        }
    }
}
