using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public GameObject sensor1, sensor2;
    public float speed_1 = 0.6f;
    public float speed_2 = 0.3f;
    GameObject SQ_;
    MainProgRobotControl SQ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().velocity = transform.right * speed_1;
    }


    // Write data

    public void OnTriggerEnter(Collider colider)
    {
        if (colider.gameObject.tag == "sensor1")
        {
            if (GameObject.Find("PLC_Mode") != null)
            {
                SQ_ = GameObject.Find("PLC_Mode");
                SQ = SQ_.GetComponent<MainProgRobotControl>();
                SQ.Sensor1(true);
            }

            StartCoroutine(ExampleCoroutine1());
        }

        if (colider.gameObject.tag == "sensor2")
        {
            if (GameObject.Find("PLC_Mode") != null)
            {
                SQ_ = GameObject.Find("PLC_Mode");
                SQ = SQ_.GetComponent<MainProgRobotControl>();
                SQ.Sensor2(true);
            }

            StartCoroutine(ExampleCoroutine2());
        }
    }

    public void OnTriggerExit(Collider colider)
    {
        if (GameObject.Find("PLC_Mode") != null)
        {
            SQ_ = GameObject.Find("PLC_Mode");
            SQ = SQ_.GetComponent<MainProgRobotControl>();
            SQ.Sensor1(false);
            SQ.Sensor2(false);
        }
    }
    IEnumerator ExampleCoroutine1()
    {
        MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();
        speed_1 = speed_2;
        yield return null;
    }
    IEnumerator ExampleCoroutine2()
    {
        MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();
        speed_1 = 0f;
        yield return null;
    }
}
