using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{

    Rigidbody2D mRB;

    [Range(0,1000)]
    public float MaxThrust=100.0f;

    public float MaxInput = 1.0f;
    public float MinInput = 0.0f;


    public string InputName = "Thrust";

    float mThrust = 0;

    public  float    Thrust {
        set {
            mThrust = Mathf.Abs(value);
        }
        get {
            return mThrust;
        }
    }

    private void Start() {
        mRB = GetComponentInParent<Rigidbody2D>();
        Debug.AssertFormat(mRB != null, "No Rigidbody2D in parent");
    }

    private void Update() {
        float tInput = Input.GetAxis(InputName);

        if(tInput >= Mathf.Min(MinInput,MaxInput) && tInput <= Mathf.Max(MinInput, MaxInput)) {
            Thrust = Mathf.Abs(tInput);
        } else {
            Thrust = 0; //If not in thrust range turn off
        }
        Debug.Log(tInput);
    }

    // Update is called once per frame
    void FixedUpdate() {
        mRB.AddForce(transform.up*MaxThrust*mThrust, ForceMode2D.Force);
    }
}
