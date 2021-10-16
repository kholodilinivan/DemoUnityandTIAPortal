using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class WaterLevelChanger : MonoBehaviour
{
    private Material _material;

    private Material Material
    {
        get
        {
            if (_material == null)
            {
                _material = GetComponent<MeshRenderer>().material;
            }
            return _material;
        }
    }

    /// <summary>
    /// </summary>
    /// <param name="value">0-1</param>
    public void SetWaterLevel(float value)
    {
        Material.SetFloat("fill", value);
    }

    public void ChangeWaterLevelOnValue(float value)
    {
        value = Material.GetFloat("fill") + value;
        value = Mathf.Clamp(value, 0, 1);
        SetWaterLevel(value);
    }
}