using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_CharacterUpright : MonoBehaviour
{
    new protected Rigidbody rigidbody;
    public bool keepUpright = true;
    public float uprightForce = 10f;
    public float uprightOffset = 1.45f;
    public float additionalUpwardForce = 10f;
    public float dampenAngularForce = 0f;

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.maxAngularVelocity = 40; // CANNOT APPLY HIGH ANGULAR FORCES UNLESS THE MAXANGULAR VELOCITY IS INCREASED
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (keepUpright)
        {
            // USE TWO FORCES PULLING UP AND DOWN AT THE TOP AND BOTTOM OF THE OBJECT TO PULL IT UPRIGHT
            rigidbody.AddForceAtPosition(new Vector3(0, (uprightForce + additionalUpwardForce), 0), transform.position + transform.TransformPoint(new Vector3(0, uprightOffset, 0)), ForceMode.Force);
            rigidbody.AddForceAtPosition(new Vector3(0, -uprightForce, 0), transform.position + transform.TransformPoint(new Vector3(0, -uprightOffset, 0)), ForceMode.Force);
        }
    }
}
