using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawingToolUiController : MonoBehaviour
{
    public Slider widthSlider;

    public Image[] buttons;
    
    private void Start() {
        widthSlider.value = GetComponentInParent<DrawingTool>().brushSize;
        
        //Init the colour buttons
        for (int i = 0; i < buttons.Length; i++) {
            buttons[i].color = GetComponentInParent<DrawingTool>().brushColours[i];
        }
    }

    public void UpdateWidth() {
        GetComponentInParent<DrawingTool>().UpdateBrushWidth(widthSlider.value);
    }


}
