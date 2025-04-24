using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramerateCap : MonoBehaviour
{
    public int target = 60;
    void Awake()
    {
        Application.targetFrameRate = target;
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.targetFrameRate != target) {
            Application.targetFrameRate = target;
        }
    }
}
