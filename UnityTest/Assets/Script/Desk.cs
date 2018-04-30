using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(name + ".OnCollisionEnter:"+ collision.gameObject.name);
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log(name + ".OnCollisionStay:" + collision.gameObject.name);
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log(name + ".OnCollisionExit:" + collision.gameObject.name);
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(name + ".OnTriggerEnter:" + other.gameObject.name);
    }
}
