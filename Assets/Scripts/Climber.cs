using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Climber : MonoBehaviour
{
    private Rigidbody rb;
    public static XRController ClimbingHand;
    public Player player;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ClimbingHand)
        {
            Climb();

        }

    }

    private void Climb()
    {
        InputDevices.GetDeviceAtXRNode(ClimbingHand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);
        rb.AddForce(transform.rotation * -velocity * Time.deltaTime*4,ForceMode.Impulse);
    }
}
