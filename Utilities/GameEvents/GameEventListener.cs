using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    #region Serialized Fields
    [SerializeField]
    protected List<GameEvent> events = new();

    [SerializeField]
    protected UnityEvent responses;

    #endregion


    #region MonoBehaviour Callbacks

    protected void OnEnable() 
    {
        foreach (GameEvent _event in events)
        {
            _event.RegisterListener(this);
        }
    }

    protected void OnDisable() 
    {
        foreach (GameEvent _event in events)
        {
            _event.UnregisterListener(this);
        }
    }

    #endregion


    #region Public Callbacks

    public virtual void Raise() => responses?.Invoke();

    public virtual void ClearAll() => responses?.RemoveAllListeners();

    #endregion
}
