// LevelEditorWindow.cs
using UnityEditor;
using UnityEngine;

public class LevelEditorWindow : EditorWindow
{
    private LevelData levelData;

    [MenuItem("Tools/Level Generator")]
    public static void ShowWindow()
    {
        GetWindow<LevelEditorWindow>("Level Generator");
    }

    void OnGUI()
    {
        GUILayout.Label("Level Configuration", EditorStyles.boldLabel);

        if (levelData == null)
            levelData = ScriptableObject.CreateInstance<LevelData>();

        SerializedObject serializedObject = new SerializedObject(levelData);
        SerializedProperty wordsProp = serializedObject.FindProperty("words");
        SerializedProperty correctWordsProp = serializedObject.FindProperty("correctWords");

        EditorGUILayout.PropertyField(wordsProp, new GUIContent("Words"), true);
        EditorGUILayout.PropertyField(correctWordsProp, new GUIContent("Correct Words"), true);

        if (GUILayout.Button("Save Level Data"))
        {
            SaveLevelData();
        }
    }

    private void SaveLevelData()
    {
        AssetDatabase.CreateAsset(levelData, $"Assets/Resources/{levelData.name}.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();
        Selection.activeObject = levelData;
    }
}
