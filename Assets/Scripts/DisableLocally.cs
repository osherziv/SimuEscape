using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class DisableLocally : MonoBehaviour
{
    [SerializeField]
    private GameObject _turnOff;
    [SerializeField]
    private RealtimeTransform _realtimeTransform;

    private void Start()
    {
        if (_realtimeTransform.isOwnedLocallySelf)
        {
            _turnOff.SetActive(false);
        }
    }
}
