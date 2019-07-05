using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap : MonoBehaviour
{
    Rigidbody2D mRB; //We will store Rigidbody2D here for fast access

    float tWidth;
    float tHeight;

    // Start is called before the first frame update
    void Start() {
        mRB = GetComponent<Rigidbody2D>(); //Get Attached Rigidbody2D
        tHeight = Camera.main.orthographicSize;     //Get size of view
        tWidth = tHeight * Camera.main.aspect;

    }
    // Update is called once per frame
    void LateUpdate()
    {
        bool tWrap = false;
        Vector2 tPosition = mRB.position;
        if(tPosition.x > tWidth) {
            tPosition.x -= 2 * tWidth;
            tWrap = true;
        } else if (tPosition.x < -tWidth) {
            tPosition.x += 2 * tWidth;
            tWrap = true;
        }

        if (tPosition.y > tHeight) {
            tPosition.y -= 2 * tHeight;
            tWrap = true;
        } else if (tPosition.y < -tHeight) {
            tPosition.y += 2 * tHeight;
            tWrap = true;
        }

        if (tWrap) {
            mRB.position = tPosition;
        }
    }
}
