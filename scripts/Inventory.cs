using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public static int charge = 0;
    public AudioClip collectSound;
    public Texture2D[] hudCharge;
    public UnityEngine.UI.RawImage chargeHUDGUI;
    public Texture2D[] meterCharge;
    public Renderer meter;
    bool haveMatches = false;
    public TextHints textHints;
	// Use this for initialization
	void Start () {
        charge = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void CellPickup() {
        AudioSource.PlayClipAtPoint(collectSound,transform.position);
        charge++;
        chargeHUDGUI.texture = hudCharge[charge];
        meter.material.mainTexture = meterCharge[charge]; 
    }
    void MatchPickup(){
        haveMatches = true;
        AudioSource.PlayClipAtPoint(collectSound,transform.position);
    }
    void OnControllerColliderHit(ControllerColliderHit col)
    {
        if(col.gameObject.name == "campfire"){
            if (haveMatches == true)
            {
                LightFire(col.gameObject);
            }
            else
                textHints.SendMessage("ShowHint","Need some matches");
        }
    }
    void LightFire(GameObject campfire){
        ParticleSystem[] fireEmitters;
        fireEmitters = campfire.GetComponentsInChildren<ParticleSystem>();
        for (int i = 0; i < fireEmitters.Length; i++){
            ParticleSystem.EmissionModule em = fireEmitters[i].emission;
            em.enabled = true;
        }
        campfire.GetComponent<AudioSource>().Play();
    }
}
