using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GFGBuilderToolsWindow : EditorWindow
{
    static List<IPagination> builderPaginations = new List<IPagination>();
    [MenuItem("Window/GFG Builder Tools")]
    public static void ShowWindow() {
        GetWindow(typeof(GFGBuilderToolsWindow));
        SetAllPaginations();
    }
    private void OnDisable() {
        builderPaginations.Clear();
    }
    int toolbarIndex = 0;
    string[] toolbarStrings = { "1", "2", "3" };
    private void OnGUI() {
        EditorGUILayout.BeginVertical(GUILayout.MinWidth(100f));
        LeftToolbar();
        EditorGUILayout.EndVertical();

        var rect = EditorGUILayout.BeginVertical(GUILayout.ExpandWidth(true));
        DrawPaginationBody(rect);
        EditorGUILayout.EndVertical();
    }
    void LeftToolbar() {
        toolbarIndex = GUILayout.SelectionGrid(toolbarIndex, toolbarStrings, 1, GUILayout.Width(50f), GUILayout.Height(100f));
    }
    IPagination currentPagination;
    void DrawPaginationBody(Rect bodyRect) {
        currentPagination = builderPaginations[toolbarIndex];
        currentPagination.DrawBody(bodyRect);
    }
    static void SetAllPaginations() {
        builderPaginations.Add(new PartsSelection());
    }
}
