using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank2Move : MonoBehaviour
{
    [SerializeField] float _speed;

    void TankMove2()
    {

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0, 0, _speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(0, 0, _speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position -= new Vector3(_speed, 0, 0) * Time.deltaTime;
        }


    }

    public void Rotate1()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 500 * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        Rotate1();
        TankMove2();
    }
}
