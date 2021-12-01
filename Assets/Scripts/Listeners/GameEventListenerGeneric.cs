using System.Collections;
using UnityEngine;
using UnityEngine.Events;


public class GameEventListenerGeneric<T> : MonoBehaviour
{
    public GameEventGeneric<T> gameEvent;
    public UnityEvent<T> gameEventCallback;

    private void OnEnable()
    {
        gameEvent.AddListener(this);
    }

    private void OnDisable()
    {
        gameEvent.RemoveListener(this);
    }

    public void OnEventRaised(T value)
    {
        gameEventCallback.Invoke(value);
    }
}