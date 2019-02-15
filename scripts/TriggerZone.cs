using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour {

    public Text textHints;
    public Light doorLight;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            if (Inventory.charge == 4)
            {
                transform.Find("door").SendMessage("DoorCheck");
                 if(GameObject.Find("PowerGUI"))
                {
                    Destroy(GameObject.Find("PowerGUI"));
                    doorLight.color = Color.green;
                }
            }
            else
            {
                textHints.SendMessage("ShowHint", "This door seems locked... maybe that generator needs power...");
            }
        }
    }
}
