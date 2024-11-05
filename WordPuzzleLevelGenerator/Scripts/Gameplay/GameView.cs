// GameView.cs
using UnityEngine;

public class GameView : MonoBehaviour
{
    public GameObject wordContainer; // Parent object containing word elements

    public void DisplayWords(string[] words)
    {
        foreach (string word in words)
        {
            GameObject wordObj = new GameObject(word);
            wordObj.transform.SetParent(wordContainer.transform);
            // Add components such as TextMesh or UI Text to display the word
            // Configure wordObj here...
        }
    }

    public void UpdateWordSelection(string word, bool isSelected)
    {
        // Update visual feedback based on whether a word is selected correctly or not
        Debug.Log(word + " selection is " + (isSelected ? "correct" : "incorrect"));
    }
}
