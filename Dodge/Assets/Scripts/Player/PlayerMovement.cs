using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Player1Input _input1;
    private Player2Input _input2;
    public Rigidbody _playerRigidBody;
    public float speed = 8f;
    void Start()
    {
        // _input에 값 할당
        _input1 = GetComponent<Player1Input>();
        _input2 = GetComponent<Player2Input>();
        _playerRigidBody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_input1.Up)
        {
            _playerRigidBody.AddForce(0f, 0f, speed);
        }
        if(_input1.Down)
        {
            _playerRigidBody.AddForce(0f, 0f, -speed);
        }
        if(_input1.Left)
        {
            _playerRigidBody.AddForce(-speed, 0f, 0f);
        }
        if(_input1.Right)
        {
            _playerRigidBody.AddForce(speed, 0f, 0f);
        }
    }
}