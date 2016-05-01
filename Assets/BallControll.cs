using UnityEngine;
using System.Collections;

public class BallControll : MonoBehaviour {

    private bool isFalling = false;

    int rotationSpeed = 100;
    int jumpHeight = 8;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        rb.AddRelativeTorque(Vector3.back * rotation);

        if (Input.GetKeyDown(KeyCode.Space) && isFalling == false) {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
        }

        isFalling = true;
    }

    void OnCollisionStay()
    {
        isFalling = false;
    }
    
}
