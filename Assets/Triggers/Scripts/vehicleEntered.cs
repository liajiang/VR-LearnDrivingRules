using UnityEngine;
using System.Collections;

public class vehicleEntered : MonoBehaviour
{

    // Use this for initialization
    public bool hasEntered = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "carBottom")
            hasEntered = true;

    }
}