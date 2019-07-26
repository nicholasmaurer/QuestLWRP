using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public Bounds sceneBounds;
    public Transform spawnPoint;
    public Transform endPoint;
    public AudioClip audioClip;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawCube(spawnPoint.transform.position, Vector3.one);
        Gizmos.color = Color.magenta;
        Gizmos.DrawCube(endPoint.transform.position, Vector3.one);
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(sceneBounds.center, sceneBounds.size);
    }
}
