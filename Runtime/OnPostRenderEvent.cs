using UnityEngine;
using UnityEngine.Events;

public class OnPostRenderEvent : MonoBehaviour
{
    UnityEvent onPostRenderEvent;

    void Start()
    {
        if (onPostRenderEvent == null)
            onPostRenderEvent = new UnityEvent();
    }

    private void OnRenderObject()
    {
        onPostRenderEvent?.Invoke();
    }
}
