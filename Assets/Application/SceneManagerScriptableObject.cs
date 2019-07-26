using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SceneManagerScriptableObject", order = 1)]
public class SceneManagerScriptableObject : ScriptableObject
{
    public Scene[] Scenes;
}