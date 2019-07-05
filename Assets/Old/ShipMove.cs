using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{

    public float MaxThrust=10.0f;
    public float MaxPitch = 10.0f;


    Rigidbody2D mRB; //We will store Rigidbody2D here for fast access
    // Start is called before the first frame update
    void Start() {
        mRB = GetComponent<Rigidbody2D>(); //Get Attached Rigidbody2D
    }

    private void FixedUpdate() {
        float tThrust = Input.GetAxis("Thrust");
        float tRotate = Input.GetAxis("Rotate");
        float tRetro = Input.GetAxis("Retro");

        tRetro = tRetro > 0.2f ? -tRetro : 1.0f;

        mRB.AddForce(transform.up * tThrust* tRetro * MaxThrust);
        mRB.SetRotation(mRB.rotation += tRotate * MaxPitch * Time.deltaTime);



    }
}
