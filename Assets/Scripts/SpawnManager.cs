using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class SpawnManager : MonoBehaviour
{
    public Realtime realtime;

    public int clientID;


    // GameObject that moves avatar to specified spawn point (attach to "Root" of Normal Local Avatar):
    [SerializeField]
    private GameObject spawnMarker;
    // List of transforms for each avatar that spawns in:
    [SerializeField]
    private Transform[] spawnPoints;
    // Track whether avatar has been moved or not: 
    [SerializeField]
    private bool avatarMoved = false;

    private void Awake()
    {
        realtime.didConnectToRoom += Realtime_didConnectToRoom;
    }
    private void Start()
    {
/*        if (!setHost.isHost)
        {
            realtime.Connect(setHost.clientRoomCodeToConnect);
        }
*/    }

    private void Realtime_didConnectToRoom(Realtime realtime)
    {
        PosAvatar(); //after connecting successfully to the room, position the avatar.
    }

    public void PosAvatar()
    {

        //when the user connects, check their clientID and move them to the spawn point for their ClientID.
/*        if (!setHost.isHost && avatarMoved == false)
        {
            spawnMarker.transform.localPosition = spawnPoints[realtime.clientID].position;
            spawnMarker.transform.localRotation = spawnPoints[realtime.clientID].rotation;
            avatarMoved = true;
        }
*/
    }

}
