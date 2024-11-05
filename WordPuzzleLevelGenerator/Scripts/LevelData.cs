// LevelData.cs
using UnityEngine;

[CreateAssetMenu(fileName = "New Level", menuName = "Level Creation/Level Data")]
public class LevelData : ScriptableObject
{
    public string[] words;
    public string[] correctWords;
    public GameObject scenePrefab; // This can be a reference to a scene or a specific animation setup
}
