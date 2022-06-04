using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using Normal.Realtime;


public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject _camera = default;
    private Realtime _realtime;

    private void Awake()
    {
        // Get the Realtime component on this game object
        _realtime = GetComponent<Realtime>();

        // Notify us when Realtime successfully connects to the room
        _realtime.didConnectToRoom += DidConnectToRoom;
    }

    private void DidConnectToRoom(Realtime realtime)
    {
        // Instantiate the Player for this client once we've successfully connected to the room
        GameObject playerGameObject = Realtime.Instantiate(prefabName: "Player",  // Prefab name
                                                                      ownedByClient: true,      // Make sure the RealtimeView on this prefab is owned by this client
                                                           preventOwnershipTakeover: true,      // Prevent other clients from calling RequestOwnership() on the root RealtimeView.
                                                                        useInstance: realtime); // Use the instance of Realtime that fired the didConnectToRoom event.

           }

}
