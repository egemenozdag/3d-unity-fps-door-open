using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollision : MonoBehaviour {
	bool beenHit = false;
	public AudioClip hitSound;
	public AudioClip resetSound;
	public float resetTime = 3.0f;
	Animation targetRoot;
	// Use this for initialization
	void Start () {
		targetRoot = transform.parent.transform.parent.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision){
		if(beenHit==false && collision.gameObject.name == "coconut")
		StartCoroutine("targetHit");
	}
	IEnumerator targetHit(){
		GetComponent<AudioSource>().PlayOneShot(hitSound);
		targetRoot.Play("down");
		beenHit = true;
		CoconutWin.targets++;
		yield return new WaitForSeconds(resetTime);
		GetComponent<AudioSource>().PlayOneShot(resetSound);
		targetRoot.Play("up");
		beenHit = false;
		CoconutWin.targets--;
		

	}
}
