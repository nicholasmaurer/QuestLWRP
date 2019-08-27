using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParachuteForce : MonoBehaviour
{
    public ConstantForce constantForce;
    [Header("xzMin, xzMax, yMin, yMax")]
    public Vector4 force;

    public Vector4 relativeForce;

    public Vector4 torque;

    public Vector3 relativeTorque;

    private Vector3 randomForce;

    private Vector3 randomRelativeForce;

    private Vector3 randomTorque;

    private Vector3 randomRelativeTorque;

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(force.x, force.y);
        float z = Random.Range(force.x, force.y);
        float y = Random.Range(force.z, force.w);
        randomForce.x = x;
        randomForce.y = y;
        randomForce.z = z;
        constantForce.force = randomForce;
    }
}
