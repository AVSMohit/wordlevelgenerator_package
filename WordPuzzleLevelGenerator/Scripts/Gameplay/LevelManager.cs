// LevelManager.cs
using UnityEngine;
using System.Linq;

public class LevelManager : MonoBehaviour
{
    public LevelData currentLevel;
    public GameObject wordPrefab; // Assign this in the inspector, a prefab for displaying words
    public Transform wordContainer; // Assign a UI container for words in the inspector

    void Start()
    {
        LoadLevel(currentLevel);
    }

    void LoadLevel(LevelData level)
    {
        Debug.Log("Level Loaded: " + level.name);
        foreach (var word in level.words)
        {
            GameObject wordObj = Instantiate(wordPrefab, wordContainer);
            wordObj.GetComponent<WordObject>().Setup(word, level.correctWords.Contains(word), this);
        }
    }

    public void WordSelected(string word, bool isCorrect)
    {
        if (isCorrect)
        {
            Debug.Log(word + " is correct!");
        }
        else
        {
            Debug.Log(word + " is incorrect. Try again!");
        }
    }
}
