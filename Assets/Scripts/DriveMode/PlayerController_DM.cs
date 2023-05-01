using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController_DM : MonoBehaviour
{
    // INPUTS FOR DRIVING
    public InputActionAsset actions;
    private InputAction pedalReverseAction;
    private InputAction steerAction;
    private InputAction brakeAction;


    // Public Game Objects
    public Rigidbody truck;
    public GameObject door;
    public WheelCollider [] tires = new WheelCollider[4];

    // Car value maximums
    public float maxTorque;
    public float maxSteer;
    public float brakeSpeed;

    // Real values given
    private float pedal;
    private float steer;
    private float brake;

    //private int [] tireState = [0,0,0,0];
   
    private int active = 0;

    void Awake()
    {
        pedalReverseAction = actions.FindActionMap("Driving").FindAction("Pedal / Reverse");

        steerAction = actions.FindActionMap("Driving").FindAction("Steer");

        brakeAction = actions.FindActionMap("Driving").FindAction("Brake");

        actions.FindActionMap("Driving").FindAction("Package Mode").performed += OnPackage;
    }

    void OnEnable()
    {
        door.SetActive(true);
        actions.FindActionMap("Driving").Enable();
    }

    void OnDisable()
    {
        door.SetActive(false);
        actions.FindActionMap("Driving").Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {
        pedal = maxTorque * pedalReverseAction.ReadValue<float>();
        steer = maxSteer * steerAction.ReadValue<float>();
        brake = brakeSpeed * brakeAction.ReadValue<float>();

        for (int i = 0; i < 4; i++)
        {
            if (i < 2)
                tires[i].steerAngle = steer;
            tires[i].motorTorque = pedal;

            tires[i].brakeTorque = brake;
        }
        
    }

    private void OnPackage(InputAction.CallbackContext context)
    {
        // Somehow communicate with overhead game controller script?
        return;
    }

    public Vector3 getXZNormal()
    {
        return Vector3.Cross(Vector3.forward, Vector3.right);
    }
}
