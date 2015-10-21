using UnityEngine;
using System.Collections;

public class Dimming : MonoBehaviour {

    public Light lightToDim = null;
    public float maxTime = 30; //30 seconds
    public float intensity = 2;
    private float mStartTime = 0;

    private void Update()
    {
        mStartTime = mStartTime + Time.deltaTime;
        if (lightToDim)
        lightToDim.intensity = (intensity - mStartTime/maxTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            mStartTime = -Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            mStartTime = -Time.deltaTime;
        }
    }

    }