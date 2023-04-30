using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_DM : MonoBehaviour
{
    // DEFAULT CAMERA POSITION
    // Expected position of camera, relative to truck.
    public Vector3 defaultPos; 
    // Expected downward rotation of camera.
    public float defaultXAngle;

    // CAMERA SMOOTHING TIMES
    // Smoothing time for camera position
    public float smoothPosTime;
    // Smoothing time for camera angle
    public float smoothAngTime;
    // Velocity of camera

    // CAMERA VELOCITIES
    private Vector3 posVelocity = Vector3.zero;
    // Angle velocity of camera, revolving around the Y-axis.
    private float yAngleVelocity = 0F;

    // CAMERA OFFSET
    // Turning pos offset -- How much extra to move because turning.
    public float posOffset = 0;
    // Turning ang offset -- How much extra angle to move due to turn.
    public float angOffset = 0;

    // DESIRED ANGLE

    private float yAngle = 0F;

    // OBJECT TO REFERENCE
    public GameObject playerDrive;
    // Start is called before the first frame update
    void Start()
    {   
        transform.position = playerDrive.transform.position + defaultPos;
        transform.Rotate(Vector3.right, defaultXAngle, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        
        yAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                        playerDrive.transform.eulerAngles.y, 
                        ref yAngleVelocity, smoothAngTime);
        
        //transform.Rotate(0F, yAngle * Time.deltaTime, 0F, Space.World);
       
        transform.position = Vector3.SmoothDamp(transform.position, 
                             playerDrive.transform.position + defaultPos,
                             ref posVelocity, smoothPosTime);
        
        transform.RotateAround(playerDrive.transform.position, 
                                Vector3.up, yAngle * Time.deltaTime);
        

    }
}
