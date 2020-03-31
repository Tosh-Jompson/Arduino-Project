using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey((KeyCode.UpArrow)))
        {
            transform.Rotate(1.0f, 0.0f, 0.0f);
        }

        if (Input.GetKey((KeyCode.DownArrow)))
        {
            transform.Rotate(-1.0f, 0.0f, 0.0f);
        }

        if (Input.GetKey((KeyCode.LeftArrow)))
        {
            transform.Rotate(0.0f, 0.0f, 1.0f);
        }

        if (Input.GetKey((KeyCode.RightArrow)))
        {
            transform.Rotate(0.0f, 0.0f, -1.0f);
        }
    }
}
