using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotOfPla : MonoBehaviour {
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseY;

    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    void Update()
    {

        float delta = Input.GetAxis("Mouse X") * sensitivityHor;
        float rotationY = transform.localEulerAngles.y + delta;

        transform.localEulerAngles = new Vector3(0, rotationY, 0);

    }
}
