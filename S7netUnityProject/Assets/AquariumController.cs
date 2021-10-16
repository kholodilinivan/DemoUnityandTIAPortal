
using UnityEngine;
using UnityEngine.Events;

public class AquariumController : MonoBehaviour
{
    public WaterLevelChanger waterLevelChanger;

    public UnityEvent<bool> P1;
    public UnityEvent<bool> P2;
    public UnityEvent<bool> P3;

    private float _motorPower;
    private float _waterOutPower;
    private float _waterLevel;
    private float _P1Level;
    private float _P2Level;
    private float _P3Level;

    private bool _P1Triggered;
    private bool _P2Triggered;
    private bool _P3Triggered;

    public void SetMotorPower(string value)
    {
        if (float.TryParse(value, out var floatValue))
        {
            _motorPower = floatValue;
        }
        else
        {
            Debug.LogError("Incorrect value: " + value);
        }
    }

    public void SetWaterOutPower(string value)
    {
        if (float.TryParse(value, out var floatValue))
        {
            _waterOutPower = floatValue;
        }
        else
        {
            Debug.LogError("Incorrect value: " + value);
        }
    }

    public void SetP1(string value)
    {
        if (float.TryParse(value, out var floatValue))
        {
            _P1Level = floatValue;
        }
        else
        {
            Debug.LogError("Incorrect value: " + value);
        }
    }

    public void SetP2(string value)
    {
        if (float.TryParse(value, out var floatValue))
        {
            _P2Level = floatValue;
        }
        else
        {
            Debug.LogError("Incorrect value: " + value);
        }
    }

    public void SetP3(string value)
    {
        if (float.TryParse(value, out var floatValue))
        {
            _P3Level = floatValue;
        }
        else
        {
            Debug.LogError("Incorrect value: " + value);
        }
    }

    private void Update()
    {
        //TODO: написать формулу, у тебя есть _motorPower, waterOutPower time
        //Time.deltaTime время между кадрами
        _waterLevel += 0.0001f;
        waterLevelChanger.SetWaterLevel(_waterLevel);
        
        if(!_P1Triggered && _waterLevel>_P1Level)
        {
            _P1Triggered = true;
            P1?.Invoke(_P1Triggered);
        }
        else if(_P1Triggered && _waterLevel<_P1Level)
        {
            _P1Triggered = false;
            P1?.Invoke(_P1Triggered);
        }

        if (!_P2Triggered && _waterLevel > _P2Level)
        {
            _P2Triggered = true;
            P2?.Invoke(_P2Triggered);
        }
        else if (_P2Triggered && _waterLevel < _P2Level)
        {
            _P2Triggered = false;
            P2?.Invoke(_P2Triggered);
        }

        if (!_P3Triggered && _waterLevel > _P3Level)
        {
            _P3Triggered = true;
            P3?.Invoke(_P3Triggered);
        }
        else if (_P3Triggered && _waterLevel < _P3Level)
        {
            _P3Triggered = false;
            P3?.Invoke(_P3Triggered);
        }
    }
}