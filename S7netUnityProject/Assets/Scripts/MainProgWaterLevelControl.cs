using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using S7.Net;
using System;
using UnityEngine.UI;

public class MainProgWaterLevelControl : MonoBehaviour

{
    Plc plc;
    // public GameObject bulb1;
    public AquariumController aquariumController;
    private float WaterInScale;
    private float WaterOutScale;

    public InputField M1;
    public InputField K1;

    // Start is called before the first frame update
    void Start()
    {
        plc = new Plc(CpuType.S71200, "127.0.0.1", 0, 1);
        plc.Open();
    }

    // Update is called once per frame
    void Update()
    {        
        // Read data
        WaterInScale = (ushort)plc.Read("DB1.DBW4.0") / 27648f; // controllong M1
        aquariumController._waterLevel += WaterInScale / 2000f;
        WaterOutScale = (ushort)plc.Read("DB1.DBW6.0") / 27648f; // controllong K1
        aquariumController._waterLevel -= WaterOutScale / 2000f;
        aquariumController._waterLevel = Mathf.Clamp(aquariumController._waterLevel, 0, 1);

        // Write data
        plc.Write("DB1.DBX0.0", aquariumController._P1Triggered); // S1 
        plc.Write("DB1.DBX0.1", aquariumController._P2Triggered); // S2
        plc.Write("DB1.DBW2.0", Convert.ToInt16(aquariumController._waterLevel * 27648f).ConvertToUshort()); // S3

        M1.text = (WaterInScale * 10).ToString();
        K1.text = (WaterOutScale * 10).ToString();

        // Debug.Log("DB1.DBW4.0: " + (ushort)plc.Read("DB1.DBW4.0"));
        // Debug.Log("WaterInScale: " + WaterInScale);
        // Debug.Log("DB1.DBX0.0: " + db1Bool1);
    }
}
