
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    private MeshRenderer mesh;
    private Material material;
    public Color onColor;
    public Color offColor;

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
        material = mesh.materials[0];
    }

    public void ChangeState(bool state)
    {
        if(state)
        {
            material.color = onColor;
        }
        else
        {
            material.color = offColor;
        }
    }

    public void On()
    {
        material.color = onColor;
    }

    public void Off()
    {
        material.color = offColor;
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
        material.color = Color.HSVToRGB(h, s, v);
    }

    public void SetValue(string value)
    {
        var newColor = onColor;
        Color.RGBToHSV(newColor, out var h, out var s, out var v);
        if (float.TryParse(value, out var result))
        {
            s = result / 255f;
        }
        material.color = Color.HSVToRGB(h, s, v);
    }
}