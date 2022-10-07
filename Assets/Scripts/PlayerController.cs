using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    public float JumpForce;
    private bool _canJump;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && _canJump){
        //jump
        _rb.AddForce(Vector3.up*JumpForce, ForceMode.Impulse);
        }
        
    }
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Ground"){
            _canJump = true; 
        }
    }

    private void OnCollisionExit(Collision collision){
         if (collision.gameObject.tag == "Ground"){
            _canJump = false;
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Obstacle"){
            SceneManager.LoadScene("Game");
        }
    }
}
