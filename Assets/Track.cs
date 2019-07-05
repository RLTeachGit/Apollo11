using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    public GameObject Target;

    Vector3 mCamPosition;
    float mOrthoSize;

    private void Start() { 
        mCamPosition = transform.position;
    }

    private void Update() {
        if(Target!=null) {
            float tXdistance =  Target.transform.position.x - transform.position.x;
            if (Mathf.Abs(tXdistance) > 1.0f) {
                mCamPosition.x += tXdistance * Time.deltaTime;
                transform.position = mCamPosition;
            }
        }
    }
}
