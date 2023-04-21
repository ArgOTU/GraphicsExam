using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLight : MonoBehaviour {
    Rigidbody body;
    [SerializeField] int moveDirection; //0 = left, 1 = right
    [SerializeField] float xLimitLeft;
    [SerializeField] float xLimitRight;
    [SerializeField] float speed = 75f;

    // Start is called before the first frame update
    void Start(){
        body = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(body.transform.position.x < xLimitLeft){
            body.MovePosition(new Vector3(xLimitRight, body.transform.position.y, body.transform.position.z));
        } else {
            body.MovePosition(body.transform.position + new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
    }
}
