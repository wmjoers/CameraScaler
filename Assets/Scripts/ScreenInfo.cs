using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScreenInfo : MonoBehaviour
{
    private TextMeshProUGUI screenInfoText;

    protected void Awake()
    {
        screenInfoText = GetComponent<TextMeshProUGUI>();
    }

    protected void Update()
    {
        screenInfoText.text = "Screen size: " + Screen.width + "x" + Screen.height + " Screen resolution: " + Screen.currentResolution.width + "x" + Screen.currentResolution.height + " Mode: " + Screen.fullScreenMode.ToString();
    }
}
