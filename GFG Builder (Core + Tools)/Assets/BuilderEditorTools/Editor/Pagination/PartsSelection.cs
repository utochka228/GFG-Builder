using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsSelection : IPagination
{
    public void DrawBody(Rect bodyRect) {
        TriggerContainer.DropAreaGUI(bodyRect);
    }
}
