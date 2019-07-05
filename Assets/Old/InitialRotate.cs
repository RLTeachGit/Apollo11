using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialRotate : MonoBehaviour
{

    Rigidbody2D mRB; //We will store Rigidbody2D here for fast access
    // Start is called before the first frame update
    void Start()
    {
        mRB = GetComponent<Rigidbody2D>(); //Get Attached Rigidbody2D
        mRB.angularVelocity = 90.0f; //Initial Spin
    }

}
