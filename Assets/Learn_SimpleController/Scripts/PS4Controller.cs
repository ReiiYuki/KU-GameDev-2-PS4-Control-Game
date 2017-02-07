using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PS4Controller : MonoBehaviour {

	// Use this for initialization
	void Start (){
	}

	private List<string> pressedButtonList = new List<string>();

	private string []ps4Buttonlist = new string[]{
		"PS4_Touch",
		"PS4_O",
		"PS4_X",
		"PS4_Triangle",
		"PS4_Square",
		"PS4_L1",
		"PS4_R1",
		"PS4_Share",
		"PS4_Options",
		"PS4_L3",
		"PS4_R3",
		"PS4_PS",
	};

	private string []ps4Axislist = new string[]{
		"PS4_R_Analog_Hor",
		"PS4_R_Analog_Ver",
		"PS4_L_Analog_Hor",
		"PS4_L_Analog_Ver",
		"PS4_L2",
		"PS4_R2",
		"PS4_DpadX",
		"PS4_DpadY",

	};

	// Update is called once per frame
	void Update () {
		for(int i=0; i<ps4Buttonlist.Length; ++i){
			if(Input.GetButtonDown(ps4Buttonlist[i])){ 
				pressedButtonList.Add( ps4Buttonlist[i] );
			}
			if(Input.GetButtonUp(ps4Buttonlist[i])){ 
				pressedButtonList.Remove( ps4Buttonlist[i] );
			}
		}
	}

	void OnGUI(){

		for(int i=0; i<ps4Axislist.Length; ++i){
			GUILayout.Label(ps4Axislist[i]+" "+Input.GetAxis(ps4Axislist[i]).ToString("N4"));
		}

		for(int i=0; i<pressedButtonList.Count; ++i){
			GUILayout.Label(pressedButtonList[i]);
		}
	}
}
