using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "GameEventGeneric", menuName = "EventsSO/GameEventGeneric")]
public class GameEventGeneric<T> : ScriptableObject
{
    private List<GameEventListenerGeneric<T>> listeners = new List<GameEventListenerGeneric<T>>();

    public void AddListener(GameEventListenerGeneric<T> newListener)
    {
        listeners.Add(newListener);
    }

    public void RemoveListener(GameEventListenerGeneric<T> listenerToRemove)
    {
        listeners.Remove(listenerToRemove);
    }

    public void Raise(T value)
    {
        foreach (var eventListener in listeners)
        {
            eventListener.OnEventRaised(value);
        }
    }
}
