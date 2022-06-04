using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using Oculus.Interaction;

public class GrabRequest : MonoBehaviour
{
    [SerializeField]
    private RealtimeTransform _realtimeTransform;

    void Start()
    {
        if (!_realtimeTransform)
            _realtimeTransform = GetComponent<RealtimeTransform>();
    }

    public void RequestGrab()
    {
        _realtimeTransform.RequestOwnership();
    }

    public void ClearGrab()
    {
        _realtimeTransform.ClearOwnership();
    }
}
