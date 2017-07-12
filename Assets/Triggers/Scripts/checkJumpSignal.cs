using UnityEngine;
using System.Collections;

public class checkJumpSignal : MonoBehaviour {

    public GameObject redLight;

    public int jumpedRedLight = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "carBottom")
            if (redLight.activeSelf == true)
                jumpedRedLight++;
    }
}
