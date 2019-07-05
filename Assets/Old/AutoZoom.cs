using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoZoom : MonoBehaviour
{

    Camera mCam;
    // Start is called before the first frame update
    void Start()
    {
        mCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        var tTracked = GameObject.FindGameObjectWithTag("Player");
        float tHeight = mCam.orthographicSize;
        float tWidth = tHeight * mCam.aspect;
        if(tTracked.transform.position.x > tWidth || tTracked.transform.position.x < -tWidth) {
            mCam.orthographicSize = Mathf.Abs(tTracked.transform.position.x / mCam.aspect);
        }
        if (tTracked.transform.position.y > tHeight || tTracked.transform.position.y < -tHeight) {
            mCam.orthographicSize = Mathf.Abs(tTracked.transform.position.y);
        }
    }
}
