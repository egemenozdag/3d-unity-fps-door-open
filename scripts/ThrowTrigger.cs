using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			CoconutThrower.canThrow = true;
		}
	}
	void OnTriggerExit(Collider col){
		if(col.gameObject.tag=="Player")
			CoconutThrower.canThrow = false;
	}
}
