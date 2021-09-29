using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelection : MonoBehaviour
{
    public GameObject mode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Modeselection(float value)
    {
        if (value == 1f)
        {
            mode.SetActive(true);
        }
        else
        {
            mode.SetActive(false);
        }
    }
}
