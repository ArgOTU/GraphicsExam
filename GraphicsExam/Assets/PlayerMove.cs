using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    Rigidbody body;
    float moveSpeed = 10;


    // Start is called before the first frame update
    void Start(){
        body = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        float xMove = Input.GetAxis("Horizontal") * moveSpeed;
        float zMove = Input.GetAxis("Vertical") * moveSpeed;

        body.MovePosition(body.transform.position + new Vector3(xMove, 0, zMove) * Time.deltaTime);
    }
}
