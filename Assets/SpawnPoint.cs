using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnPoint : MonoBehaviour
{
    public enum SpawnType
    {
        start,
        end
    }
    public class SpawnPointEnteredEvent : UnityEvent<SpawnType>
    {
        
    }

    public SpawnPointEnteredEvent _onSpawnPointEntered = new SpawnPointEnteredEvent();

    public SpawnType _spawnType;
    private void OnTriggerEnter(Collider other)
    {
        if (_onSpawnPointEntered != null)
        {
            _onSpawnPointEntered.Invoke(_spawnType);
        }
    }

    public void Spawn()
    {
        
    }
}
