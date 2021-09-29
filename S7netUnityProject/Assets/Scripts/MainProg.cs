using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using S7.Net;
using System;

public class MainProg : MonoBehaviour

{
    Plc plc;
    // public GameObject bulb1;
    private MaterialChanger MaterialChanger_vd1;
    private MaterialChanger MaterialChanger_vd2;
    private MaterialChanger MaterialChanger_vd3;
    private MaterialChanger MaterialChanger_vd4;
    private MaterialChanger MaterialChanger_vd5;
    private MaterialChanger MaterialChanger_vd6;

    // Start is called before the first frame update
    void Start()
    {
        MaterialChanger_vd1 = GameObject.Find("VD1").GetComponent<MaterialChanger>();
        MaterialChanger_vd2 = GameObject.Find("VD2").GetComponent<MaterialChanger>();
        MaterialChanger_vd3 = GameObject.Find("VD3").GetComponent<MaterialChanger>();
        MaterialChanger_vd4 = GameObject.Find("VD4").GetComponent<MaterialChanger>();
        MaterialChanger_vd5 = GameObject.Find("VD5").GetComponent<MaterialChanger>();
        MaterialChanger_vd6 = GameObject.Find("VD6").GetComponent<MaterialChanger>();

        plc = new Plc(CpuType.S71200, "127.0.0.1", 0, 1);
        plc.Open();
    }

    // Update is called once per frame
    void Update()
    {
        // Read data
        bool db1Bool1 = (bool)plc.Read("DB1.DBX6.0"); 
        if (db1Bool1 == true) MaterialChanger_vd1.On();
        else 
        {
            MaterialChanger_vd1.Off();
            MaterialChanger_vd1.SetValue((ushort)plc.Read("DB1.DBW8.0"));
        }

        bool db1Bool2 = (bool)plc.Read("DB1.DBX6.1");
        if (db1Bool2 == true) MaterialChanger_vd2.On();
        else
        {
            MaterialChanger_vd2.Off();
            MaterialChanger_vd2.SetValue((ushort)plc.Read("DB1.DBW10.0"));
        }

        bool db1Bool3 = (bool)plc.Read("DB1.DBX6.2");
        if (db1Bool3 == true) MaterialChanger_vd3.On();
        else
        {
            MaterialChanger_vd3.Off();
            MaterialChanger_vd3.SetValue((ushort)plc.Read("DB1.DBW12.0"));
        }

        bool db1Bool4 = (bool)plc.Read("DB1.DBX6.3");
        if (db1Bool4 == true) MaterialChanger_vd4.On();
        else
        {
            MaterialChanger_vd4.Off();
            MaterialChanger_vd4.SetValue((ushort)plc.Read("DB1.DBW14.0"));
        }

        bool db1Bool5 = (bool)plc.Read("DB1.DBX6.4");
        if (db1Bool5 == true) MaterialChanger_vd5.On();
        else
        {
            MaterialChanger_vd5.Off();
            MaterialChanger_vd5.SetValue((ushort)plc.Read("DB1.DBW16.0"));
        }

        bool db1Bool6 = (bool)plc.Read("DB1.DBX6.5");
        if (db1Bool6 == true) MaterialChanger_vd6.On();
        else
        {
            MaterialChanger_vd6.Off();
            MaterialChanger_vd6.SetValue((ushort)plc.Read("DB1.DBW18.0"));
        }

        // var db1Int1 = (ushort)plc.Read("DB1.DBW2.0");
        // Debug.Log("DB1.DBW2.0: " + db1Int1);

        // Debug.Log("DB1.DBX0.0: " + db1Bool1);
        // Debug.Log("DB1.DBX0.1: " + db1Bool2);
    }


    // Write data
    // Buttons (discrete signals)
    public void btn1()
    {
        plc.Write("DB1.DBX0.0", true);
    }
    public void btn1_end()
    {
        plc.Write("DB1.DBX0.0", false);
    }

    public void btn2()
    {
        plc.Write("DB1.DBX0.1", true);
    }
    public void btn2_end()
    {
        plc.Write("DB1.DBX0.1", false);
    }

    public void btn3()
    {
        plc.Write("DB1.DBX0.2", true);
    }
    public void btn3_end()
    {
        plc.Write("DB1.DBX0.2", false);
    }

    // Slider (analog signal)
    public void slider(float value)
    {        
        plc.Write("DB1.DBW2.0", Convert.ToInt16(value).ConvertToUshort());
    }
    // Input Field (analog signal)
    public void inputfield(string value)
    {
        plc.Write("DB1.DBW4.0", Convert.ToInt16(value).ConvertToUshort());
    }

}
