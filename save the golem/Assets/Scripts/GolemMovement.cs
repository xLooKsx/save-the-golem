using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemMovement : MonoBehaviour{

    private Rigidbody myBody;
    private float moveForce = 10f; 

    // Start is called before the first frame update
    void Awake() {
        myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        float h = Input.GetAxis("Horizontal");
        myBody.velocity = new Vector3(-h * moveForce, 0f, 0f);
    }
}
