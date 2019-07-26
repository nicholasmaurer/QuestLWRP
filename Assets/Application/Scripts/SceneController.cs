using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public Bounds sceneBounds;
    public SpawnPoint startPoint;
    public SpawnPoint endPoint;
    public Camera sceneCamera;

    private void OnEnable()
    {
        endPoint._onSpawnPointEntered.AddListener(OnEndPointEntered);
    }

    private void OnDisable()
    {
        endPoint._onSpawnPointEntered.RemoveListener(OnEndPointEntered);
    }

    // Start is called before the first frame update
    void Start()
    {
        startPoint.Spawn();
    }

    private void OnEndPointEntered(SpawnPoint.SpawnType arg0)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawCube(startPoint.transform.position, Vector3.one);
        Gizmos.color = Color.magenta;
        Gizmos.DrawCube(endPoint.transform.position, Vector3.one);
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(sceneBounds.center, sceneBounds.extents);
    }
}
