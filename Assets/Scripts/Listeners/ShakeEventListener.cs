using System.Collections;
using UnityEngine;
using UnityEngine.Events;


public class ShakeEventListener : MonoBehaviour
{
    public ShakeEvent gameEvent;
    public UnityEvent gameEventCallback;

    private void OnEnable()
    {
        gameEvent.AddListener(this);
    }

    private void OnDisable()
    {
        gameEvent.RemoveListener(this);
    }

    public void OnEventRaised()
    {
        gameEventCallback.Invoke();
    }
}