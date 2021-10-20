
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AquariumController : MonoBehaviour
{
    public WaterLevelChanger waterLevelChanger;

    public UnityEvent<bool> P1;
    public UnityEvent<bool> P2;

    public UnityEvent<bool> M1;
    public UnityEvent<bool> K1;

    public InputField LevelLiters;
    public InputField LevelVolts;

    private float _motorPower;
    private float _waterOutPower;
    public float _waterLevel;
    private float _P1Level = 0.5f;
    private float _P2Level = 0.75f;

    public bool _P1Triggered;
    public bool _P2Triggered;

    private bool WaterInTriggered;
    private bool WaterOutTriggered;

    public void SetMotorPower(string value)
    {
        if (float.TryParse(value, out var floatValue))
        {
            _motorPower = floatValue;
            _motorPower = Mathf.Clamp(_motorPower, 0, 10);
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
            _waterOutPower = Mathf.Clamp(_waterOutPower, 0, 10);
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
            _P1Level = floatValue/100;
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
            _P2Level = floatValue/100;
        }
        else
        {
            Debug.LogError("Incorrect value: " + value);
        }
    }

    private void Update()
    {
        //TODO: написать формулу, у тебя есть _motorPower, _waterOutPower time
        //Time.deltaTime время между кадрами
        //_waterLevel += 0.0001f;

        _waterLevel += _motorPower/20000;
        _waterLevel -= _waterOutPower/20000;
        _waterLevel = Mathf.Clamp(_waterLevel, 0, 1);

        waterLevelChanger.SetWaterLevel(_waterLevel);

        LevelLiters.text = (_waterLevel*100).ToString();
        LevelVolts.text = (_waterLevel*10).ToString();


        if (!_P1Triggered && _waterLevel>_P1Level)
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



        if (_motorPower != 0)
        {
            WaterInTriggered = true;
            M1?.Invoke(WaterInTriggered);
        }
        else
        {
            WaterInTriggered = false;
            M1?.Invoke(WaterInTriggered);
        }

        if (_waterOutPower != 0)
        {
            WaterOutTriggered = true;
            K1?.Invoke(WaterOutTriggered);
        }
        else
        {
            WaterOutTriggered = false;
            K1?.Invoke(WaterOutTriggered);
        }

    }
}