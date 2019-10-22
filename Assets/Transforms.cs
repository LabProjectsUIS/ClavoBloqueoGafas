using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transforms : MonoBehaviour {

   
        public float moveSpeed = 10f;
        public float turnSpeed = 20f;
        float accelx, accely, accelz = 0;


    void Update()
        {
        accelx = Input.acceleration.x;
        accely = Input.acceleration.y;
        accelz = Input.acceleration.z;
        transform.Rotate(accelx * Time.deltaTime, accely * Time.deltaTime, accelz * Time.deltaTime);

        //Translate cube
            if (Input.GetKey(KeyCode.Y))
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.U))
                transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.I))
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.O))
                transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.DownArrow))
                transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
            
            if (Input.GetKey(KeyCode.H))
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.J))
                transform.Rotate(-Vector3.up, turnSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.K))
                transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.L))
                transform.Rotate(Vector3.right, -turnSpeed*Time.deltaTime);
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(-Vector3.forward * turnSpeed * Time.deltaTime);

    }
    

}
