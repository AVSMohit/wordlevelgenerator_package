// WordObject.cs
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Make sure to have the TextMeshPro package installed

public class WordObject : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    private bool isCorrect;
    private LevelManager levelManager;

    public void Setup(string word, bool correct, LevelManager manager)
    {
        textDisplay.text = word;
        isCorrect = correct;
        levelManager = manager;
    }

    public void OnWordSelected()
    {
        levelManager.WordSelected(textDisplay.text, isCorrect);
    }
}
