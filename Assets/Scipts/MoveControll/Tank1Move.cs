using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank1Move : MonoBehaviour
{

    [SerializeField] float _speed;
  
    void TankMove1()
    {

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime ;
           
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0,0, _speed) *Time.deltaTime;
            

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0,0,_speed)*Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position -= new Vector3(_speed, 0,0)*Time.deltaTime;
          
        }


    }

    public void Rotate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2"));
        Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 500 * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        TankMove1();
        Rotate();
    }



}
