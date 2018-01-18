using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavy : MonoBehaviour {

	public float smooth = 20;

	// Use this for initialization
	void Start () 
	{   
		SwingOpen ();
	}

	// Update is called once per frame
	void Update () 
	{

	}

	void SwingOpen()
	{   
		Quaternion newRotation = new Quaternion(transform.rotation.x,transform.rotation.y,transform.rotation.z,transform.rotation.w);;
		newRotation *= Quaternion.Euler(0, 90, 0); // this add a 90 degrees Y rotation
		transform.rotation= Quaternion.Slerp(transform.rotation, newRotation,20 * Time.deltaTime);      

	}

}