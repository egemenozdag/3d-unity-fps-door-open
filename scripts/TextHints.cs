using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHints : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Showint(string message) {
        GetComponent<Text>().text = message;
        if (!GetComponent<Text>().enabled)
        {
            GetComponent<Text>().enabled = true;
        }
    }
}
