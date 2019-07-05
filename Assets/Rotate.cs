using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float Speed = 90.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float tRotation = Input.GetAxis("Rotate");
        if(Mathf.Abs(tRotation)>0.1f) {
            transform.Rotate(0, 0, tRotation * Time.deltaTime * Speed);

        }
    }
}
