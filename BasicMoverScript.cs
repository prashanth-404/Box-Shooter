using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMoverScript : MonoBehaviour
{
    public enum motionDirection { Spin, Horizontal, Vertical };
    public motionDirection motionstate = motionDirection.Horizontal;

    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;

    // Update is called once per frame
    void Update()
    {
        switch (motionstate)
        {
            case motionDirection.Spin:
                gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
                break;
            case motionDirection.Horizontal:
                gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;
            case motionDirection.Vertical:
                gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;
        }
    }
}
