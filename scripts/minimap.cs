using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour {
	public Transform TargetCam;
	// Use this for initialization
	void Start () {
		
	}
	void Update(){}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3 (TargetCam.position.x,TargetCam.position.y,TargetCam.position.z);
		transform.rotation.Set(TargetCam.rotation.w,TargetCam.rotation.x,TargetCam.rotation.y,TargetCam.rotation.z);
	}
}
