using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChickenColor : MonoBehaviour {
    private Color32 currentColor;
    public Color32 CurrentColor { get { return currentColor; } }
    public void ChangeColor(Color32 color) {
        currentColor = color;
        VisualizeColor();
    }
    private void VisualizeColor() {
        gameObject.GetComponentInChildren<Renderer>().material.SetColor("_BaseColor", currentColor);
    }
}