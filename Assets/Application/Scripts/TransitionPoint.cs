using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionPoint : MonoBehaviour
{
    private float timer = 0;
    private float maxTime = 3f;
    private bool maxTimeReached = false;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > maxTime)
        {
            maxTimeReached = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!maxTimeReached)
            return;
        Debug.Log("TransitionPoint: OnTriggerEnter");
        SceneController.Instance.StartCoroutine(SceneController.Instance.LoadNextScene());
    }
}
