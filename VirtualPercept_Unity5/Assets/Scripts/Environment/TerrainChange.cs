using UnityEngine;
using System.Collections;
using Tags;

public class TerrainChange : MonoBehaviour {
	
	public AudioClip sound;

	private PlayerController playerController;

	void Start(){
		GameController._instance.OnInitial += this.OnInitial;
	}

	void OnInitial(){
		playerController = GameObject.FindGameObjectWithTag(UnityTag.Player).GetComponent<PlayerController>();

	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			playerController.SetAudio(sound);
		}
	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Player"){
			playerController.ResetAudio();
		}
	}


}
