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
    private static bool isLoading = false;
    public static SceneController Instance;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }
    public IEnumerator LoadNextScene()
    {
        if(isLoading)
            yield break;
        isLoading = true;
        Scene scene = SceneManager.GetActiveScene();
        int activeBuildIndex = scene.buildIndex;
        int loadBuildIndex = 0;
        if (SceneManager.sceneCountInBuildSettings > activeBuildIndex + 1)
        {
            loadBuildIndex = activeBuildIndex + 1;
        }
        else
        {
            loadBuildIndex = 0;
            Debug.Log("SceneManager has run out of scenes to load, loading first scene.");
        }

        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(loadBuildIndex, LoadSceneMode.Additive);
        yield return new WaitUntil(()=> loadOperation.isDone);
        AsyncOperation unLoadOperation = SceneManager.UnloadSceneAsync(scene);
        isLoading = false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(sceneBounds.center, sceneBounds.extents);
    }
    
}
