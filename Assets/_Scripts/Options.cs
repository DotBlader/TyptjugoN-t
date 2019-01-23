using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public int onOff;
    // Start is called before the first frame update
    void Start()
    {
        onOff = PlayerPrefs.GetInt("påAv");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("påAv", onOff);
    }
    public void On()
    {
        if (onOff != 1)
        onOff = 1;
        else if (onOff == 1)
            onOff = 0;
    }
    
}
