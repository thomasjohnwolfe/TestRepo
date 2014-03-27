﻿using UnityEngine;
using System.Collections;

public class ResetPos : MonoBehaviour {
	public GameObject startPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//move the trigger checkpoint to carrally and anarchy script
		/*
		if(Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.Joystick1Button6))
		{
			RESETPOS(GameObject.FindGameObjectWithTag("Player"));
		}
		*/
		if(Input.GetKeyDown(KeyCode.Backspace))
		{
			Application.LoadLevel(Application.loadedLevel);
		}

	}

	public void RESETPOS(GameObject g){
		//GameObject.FindGameObjectWithTag("CheckPointManager").SendMessage("subPlace",GameObject.FindGameObjectWithTag("Player").GetComponent<playerID>().ID);
		GameSoundCommands.instance.PlayStartSound();
		g.transform.position = startPos.transform.position;;
		g.transform.rotation = startPos.transform.rotation;
		g.rigidbody.velocity = Vector3.zero;
		g.rigidbody.angularVelocity = Vector3.zero;
	}
}
