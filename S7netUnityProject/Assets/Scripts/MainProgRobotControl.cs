using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using S7.Net;
using System;

public class MainProgRobotControl : MonoBehaviour

{
    Plc plc;
    public GameObject myPrefabRed, myPrefabGreen, myPrefabBlue;
    float speed_1 = 0.6f;
    float speed_2 = 0.3f;
    GameObject obj;
    GameObject robot_move_;
    RobotMove robot_move;
    public int sensor;
    int redMemory, greenMemory, blueMemory;
    int redMoveMemory, greenMoveMemory, blueMoveMemory;

    // Start is called before the first frame update
    void Start()
    {
        plc = new Plc(CpuType.S71200, "127.0.0.1", 0, 1);
        plc.Open();

        robot_move_ = GameObject.Find("Robot1");
        robot_move = robot_move_.GetComponent<RobotMove>();

        redMemory = 1;
        greenMemory = 1;
        blueMemory = 1;

        redMoveMemory = 1;
        greenMoveMemory = 1;
        blueMoveMemory = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Read data
        bool db1Bool1 = (bool)plc.Read("DB1.DBX0.6"); // red cube
        if (db1Bool1 == false) redMemory = redMemory * 0;
        if (db1Bool1 == true) InstantiateRed(0, redMemory);

        bool db1Bool2 = (bool)plc.Read("DB1.DBX0.7"); // green cube
        if (db1Bool2 == false) greenMemory = greenMemory * 0;
        if (db1Bool2 == true) InstantiateGreen(0, greenMemory);

        bool db1Bool3 = (bool)plc.Read("DB1.DBX1.0"); // blue cube
        if (db1Bool3 == false) blueMemory = blueMemory * 0;
        if (db1Bool3 == true) InstantiateBlue(0, blueMemory);

        bool db1Bool4 = (bool)plc.Read("DB1.DBX1.4"); // conveyor
        bool db1Bool5 = (bool)plc.Read("DB1.DBX1.5"); // conveyor
        if (db1Bool4 == true)
        {
            InstantiateRed(speed_1, 1); 
            InstantiateGreen(speed_1, 1);
            InstantiateBlue(speed_1, 1);
        }
        else if (db1Bool5 == true)
        {
            InstantiateRed(speed_2, 1);
            InstantiateGreen(speed_2, 1);
            InstantiateBlue(speed_2, 1);
        }
        else
        {
            InstantiateRed(0, 1);
            InstantiateGreen(0, 1);
            InstantiateBlue(0, 1);
        }

        bool db1Bool6 = (bool)plc.Read("DB1.DBX1.1"); // robot move red
        if (db1Bool6 == false) redMoveMemory = redMoveMemory * 0;
        if (db1Bool6 == true && redMoveMemory == 0)
        {
            robot_move.GrabRed();
            RobotProceed(true, false);
            redMoveMemory = 1;
        }

        bool db1Bool7 = (bool)plc.Read("DB1.DBX1.2"); // robot move green
        if (db1Bool7 == false) greenMoveMemory = greenMoveMemory * 0;

        if (db1Bool7 == true && greenMoveMemory == 0)
        {
            robot_move.GrabGreen();
            RobotProceed(true, false);
            greenMoveMemory = 1;
        }

        bool db1Bool8 = (bool)plc.Read("DB1.DBX1.3"); // robot move blue
        if (db1Bool8 == false) blueMoveMemory = blueMoveMemory * 0;
        if (db1Bool8 == true && blueMoveMemory == 0)
        {
            robot_move.GrabBlue();
            RobotProceed(true, false);
            blueMoveMemory = 1;
        }
    }


    // Write data
    // Buttons (discrete signals)

    public void RobotProceed(bool state,bool finish)
    {
        if (redMoveMemory == 0 || greenMoveMemory == 0 || blueMoveMemory == 0 || finish == true)
        plc.Write("DB1.DBX0.5", state);
    }

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

    public void InstantiateRed(float speed, int control)
    {
        if (control == 0)
        {
            obj = Instantiate(myPrefabRed, new Vector3(-5.474f, 1.11f, 20.0969f), Quaternion.Euler(0, -24.176f, 0));
            obj.GetComponent<CubeMove>().enabled = false;
            redMemory = 2;
        }
        if (obj != null)
        {
            obj.GetComponent<CubeMove>().enabled = true;
            obj.GetComponent<CubeMove>().speed_1 = speed;
            obj.GetComponent<CubeMove>().speed_2 = speed;
        }
    }

    public void InstantiateGreen(float speed, int control)
    {
        if (control == 0)
        {
            obj = Instantiate(myPrefabGreen, new Vector3(-5.474f, 1.11f, 20.0969f), Quaternion.Euler(0, -24.176f, 0));
            obj.GetComponent<CubeMove>().enabled = false;
            greenMemory = 2;
        }
        if (obj != null)
        {
            obj.GetComponent<CubeMove>().enabled = true;
            obj.GetComponent<CubeMove>().speed_1 = speed;
            obj.GetComponent<CubeMove>().speed_2 = speed;
        }
    }
    public void InstantiateBlue(float speed, int control)
    {
        if (control == 0)
        {
            obj = Instantiate(myPrefabBlue, new Vector3(-5.474f, 1.11f, 20.0969f), Quaternion.Euler(0, -24.176f, 0));
            obj.GetComponent<CubeMove>().enabled = false;
            blueMemory = 2;
        }
        if (obj != null)
        {
            obj.GetComponent<CubeMove>().enabled = true;
            obj.GetComponent<CubeMove>().speed_1 = speed;
            obj.GetComponent<CubeMove>().speed_2 = speed;
        }
    }

    public void Sensor1(bool state)
    {
        plc.Write("DB1.DBX0.3", state);
    }

    public void Sensor2(bool state)
    {
        plc.Write("DB1.DBX0.4", state);
    }
}
