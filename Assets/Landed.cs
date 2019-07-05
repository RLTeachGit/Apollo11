using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landed : MonoBehaviour
{

    AudioSource mAS;

    bool mPlay = false;
    // Start is called before the first frame update
    void Start()
    {
        mAS = GetComponent<AudioSource>();
        StartCoroutine(EagleHasLanded());
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Moon") {
            mPlay = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.tag == "Moon") {
            mPlay = false;
        }
    }

    IEnumerator EagleHasLanded() {

        for(; ; ) {
            if(mPlay) {
                yield return new WaitForSeconds(2.0f);
                if(mPlay) {
                    mAS.Play();
                    yield return new WaitForSeconds(mAS.clip.length);
                    mPlay = false;
                }
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
}
