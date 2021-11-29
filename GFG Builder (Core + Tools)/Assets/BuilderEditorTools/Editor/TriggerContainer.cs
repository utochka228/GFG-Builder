using UnityEngine;
using System.Collections;

using UnityEditor;

public class TriggerContainer
{
    public static void DropAreaGUI(Rect parentRect) {
        Event evt = Event.current;
        GUI.Box(parentRect, "Add Trigger");
        switch (evt.type) {
            case EventType.DragUpdated:
            case EventType.DragPerform:
                if (!parentRect.Contains(evt.mousePosition))
                    return;

                DragAndDrop.visualMode = DragAndDropVisualMode.Copy;

                if (evt.type == EventType.DragPerform) {
                    DragAndDrop.AcceptDrag();

                    foreach (Object dragged_object in DragAndDrop.objectReferences) {
                        // Do On Drag Stuff here
                    }
                }
                break;
        }
    }
}