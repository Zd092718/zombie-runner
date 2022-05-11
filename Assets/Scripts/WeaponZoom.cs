using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOut = 60f;
    [SerializeField] float zoomedIn = 30f;
    [SerializeField] float zoomedInSensitivity = 0.5f;
    [SerializeField] float zoomedOutSensitivity = 2f;



    bool zoomedInToggle = false;
    // Update is called once per frame

    private void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                mainCamera.fieldOfView = zoomedIn;
                fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedInSensitivity;
            }
            else
            {
                zoomedInToggle = false;
                mainCamera.fieldOfView = zoomedOut;
                fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;

            }


        }
    }
}
