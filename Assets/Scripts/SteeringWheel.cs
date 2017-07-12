using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class SteeringWheel : MonoBehaviour {

	public int degreeOfFreedom = 240;

	private Transform wheel;

	void Start () {
		wheel = GetComponent<Transform> ();
	}

	void FixedUpdate () {
		float h = CrossPlatformInputManager.GetAxis("Horizontal");
		float angle = h * degreeOfFreedom;
		wheel.localRotation = Quaternion.Euler(angle, 0.0f, 7.0191f);
	}
}
