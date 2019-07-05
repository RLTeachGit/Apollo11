using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float XMultiplier = 0.1f;
    public float YMultiplier = 0.1f;

    public Vector3 mInitalPos;

    private void Start() {
        mInitalPos = transform.position;
    }

    //Add position adjustment for parallax
    void LateUpdate()
    {
        float tX = mInitalPos.x - transform.parent.position.x * XMultiplier;
        float ty = mInitalPos.y - transform.parent.position.y * YMultiplier;
        transform.localPosition = new Vector3(tX,ty, -transform.parent.position.z);    
    }
}
