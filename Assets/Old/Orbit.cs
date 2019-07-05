using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public  Transform Origin;

    float mTime = 0;
    public float Speed = 0.1f;
    public  float MajorAxis = 14;
    public  float MinorAxis = 7;


    Rigidbody2D mRB; //We will store Rigidbody2D here for fast access
    // Start is called before the first frame update
    void Start() {
        mRB = GetComponent<Rigidbody2D>(); //Get Attached Rigidbody2D
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mTime += Time.deltaTime;
        Vector2 tPosition = new Vector2(Mathf.Cos(mTime*Speed) * MajorAxis + Origin.position.x, Mathf.Sin(mTime*Speed) * MinorAxis + Origin.position.y);
        mRB.MovePosition(tPosition);
    }
}
