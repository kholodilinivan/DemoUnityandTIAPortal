
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    private Image image;
    public Color onColor;
    public Color offColor;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void ChangeState(bool state)
    {
        if(state)
        {
            image.color = onColor;
        }
        else
        {
            image.color = offColor;
        }
    }

    public void On()
    {
        image.color = onColor;
    }

    public void Off()
    {
        image.color = offColor;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value">0-255</param>
    public void SetValue(float value)
    {
        var newColor = onColor;
        Color.RGBToHSV(newColor, out var h, out var s, out var v);
        s = value / 255f;
        image.color = Color.HSVToRGB(h, s, v);
    }

    public void SetValue(string value)
    {
        var newColor = onColor;
        Color.RGBToHSV(newColor, out var h, out var s, out var v);
        if (float.TryParse(value, out var result))
        {
            s = result / 255f;
        }
        image.color = Color.HSVToRGB(h, s, v);
    }
}