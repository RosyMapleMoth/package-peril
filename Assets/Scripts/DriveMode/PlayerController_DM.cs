using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_DM : MonoBehaviour
{
    public Rigidbody truck;
    //public Vector3[] forceVectors = new Vector3[4];

    /*
    public float maxSpeed;
    public float turnSpeed;
    public float accelSpeed;
    public float maxSteer;

    private int [] tireState = [0,0,0,0];
    private int tireIndex;
    private float tireAngle = 0;
    private float frontSpeed = 0;
    private float rearSpeed = 0;
    */




    private int active = 0;
    private float offset = 5F;
    // Start is called before the first frame update
    void Start()
    {
        truck = GetComponent <Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {
        
    }
}
