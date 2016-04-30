using UnityEngine;
using System.Collections;

public class BallControll : MonoBehaviour {

    float rotationSpeed = 100;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        rb.AddRelativeTorque(Vector3.back * rotation);
    }
    
}
