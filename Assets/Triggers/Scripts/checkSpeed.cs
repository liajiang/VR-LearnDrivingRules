using UnityEngine;
using System.Collections;

public class checkSpeed : MonoBehaviour {

    public GameObject car;
    private Rigidbody rb;
    public int topSpeed = 0;
    private int currentSpeed;
    void Start()
    {
        rb = car.GetComponent<Rigidbody>();
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "carBottom")
            currentSpeed =(int)(rb.velocity.magnitude* 2.23693629f);
        if ((int)currentSpeed > topSpeed)
            topSpeed = currentSpeed;
        Debug.Log(currentSpeed);
    }
}
