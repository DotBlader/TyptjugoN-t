using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PåAvFärg : MonoBehaviour
{
    public Image mat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("påAv") == 1)
        {
            mat.color = Color.green;
        }
        else
        {
            mat.color = Color.red;
        }
    }
}
