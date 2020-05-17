using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotation : MonoBehaviour
{
    public Vector3 RotateAmount;  // degrees per second to rotate in each axis. Set in inspector.

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0 * Time.deltaTime);
    }
}
