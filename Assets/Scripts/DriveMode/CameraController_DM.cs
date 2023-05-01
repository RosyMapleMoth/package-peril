using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_DM : MonoBehaviour
{
    // DEFAULT CAMERA POSITION
    // Expected position of camera, relative to truck.
    public float defaultPosY;
    public float defaultPosZ;
    // Focus of camera
    private Vector3 focus;
    // Distance the focus is from the camera.
    public float focusDist;

    // OBJECT TO REFERENCE
    public GameObject playerDrive;
    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {   
        
        Vector3 pdForwardOnXZ = Vector3.ProjectOnPlane(playerDrive.transform.forward, Vector3.up).normalized;
        Vector3 pdRightOnXZ = Vector3.ProjectOnPlane(playerDrive.transform.right, Vector3.up).normalized;

        transform.position = playerDrive.transform.position + Vector3.up * defaultPosY + pdForwardOnXZ * defaultPosZ;

        focus = playerDrive.transform.position + pdForwardOnXZ * focusDist;

        transform.LookAt(focus);

    }
}
