using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiate : MonoBehaviour
{
    public GameObject myPrefabRed, myPrefabGreen, myPrefabBlue;

    void Start()
    {

    }

    public void InstantiateRed()
    {
        GameObject obj = Instantiate(myPrefabRed, new Vector3(-5.474f, 1.11f, 20.0969f), Quaternion.Euler(0, -24.176f, 0));
    }

    public void InstantiateGreen()
    {
        GameObject obj = Instantiate(myPrefabGreen, new Vector3(-5.474f, 1.11f, 20.0969f), Quaternion.Euler(0, -24.176f, 0));
    }
    public void InstantiateBlue()
    {
        GameObject obj = Instantiate(myPrefabBlue, new Vector3(-5.474f, 1.11f, 20.0969f), Quaternion.Euler(0, -24.176f, 0));
    }
}
