using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Bounds sceneBounds;
    public GameObject vrCamera;
    public GameObject firstPersonCamera;
    private bool isLoading = false;
    public static SceneController Instance;
    private static SceneController instance;
    
    private void Awake()
    {
        instance = this;
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = instance;
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(vrCamera);
            DontDestroyOnLoad(firstPersonCamera);
        }
    }
    
    public IEnumerator LoadNextScene()
    {
        if(isLoading)
            yield break;
        isLoading = true;
        Scene scene = SceneManager.GetActiveScene();
        int buildIndex = scene.buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings < buildIndex -1)
        {
            Debug.LogError("SceneManager has run out of scenes to load, you may need to add your scene to the build index.");
            yield break;
        }
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive);
        yield return new WaitUntil(()=> loadOperation.isDone);
        AsyncOperation unLoadOperation = SceneManager.UnloadSceneAsync(scene);
        isLoading = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
//        Gizmos.color = Color.green;
//        Gizmos.DrawCube(startPoint.transform.position + new Vector3(0,0.5f,0), Vector3.one);
//        Gizmos.color = Color.red;
//        Gizmos.DrawCube(endPoint.transform.position + new Vector3(0,0.5f,0), Vector3.one);
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(sceneBounds.center, sceneBounds.extents);
    }

    private void OnDestroy()
    {
        Destroy(vrCamera);
        Destroy(firstPersonCamera);
    }
}
