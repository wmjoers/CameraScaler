using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScreenInfo : MonoBehaviour
{
    private TextMeshProUGUI screenInfoText;
    private int lastWidth = 0;
    private int lastHeight = 0;

    protected void Awake()
    {
        screenInfoText = GetComponent<TextMeshProUGUI>();
    }

    protected void Update()
    {
        if (Screen.width != lastWidth || Screen.height != lastHeight)
        {
            screenInfoText.text = "" + Screen.width + "x" + Screen.height; 
            lastWidth = Screen.width;
            lastHeight = Screen.height;
        }
    }
}
