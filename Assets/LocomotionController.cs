﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class LocomotionController : MonoBehaviour
{
    public XRController leftTeleportRay;
    public XRController rightTeleportRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = 1f;

    // Update is called once per frame
    void Update()
    {
        if (leftTeleportRay)
        {
            leftTeleportRay.gameObject.SetActive(false);
            //leftTeleportRay.gameObject.SetActive(CheckIfActivated(leftTeleportRay));
        }


        if (rightTeleportRay)
        {

            rightTeleportRay.gameObject.SetActive(CheckIfActivated(rightTeleportRay));
        }


    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActived, activationThreshold);
        return isActived;

    }

}
