using UnityEngine;
using System.Collections;

public class TestPS4Controller : MonoBehaviour {

	public Transform lCube;
	public Transform rCube;

	private Vector3 oriPos_LCube = Vector3.zero;
	private Vector3 oriPos_RCube = Vector3.zero;

	private Vector3 curPos_LCube = Vector3.zero;
	private Vector3 curPos_RCube = Vector3.zero;

	public float sensitivity = 10f;



	// Use this for initialization
	void Start () {
		oriPos_LCube = lCube.localPosition;
		oriPos_RCube = rCube.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		curPos_LCube = oriPos_LCube;
		curPos_RCube = oriPos_RCube;

		curPos_LCube.x += Input.GetAxis("PS4_L_Analog_Hor") * sensitivity;
		curPos_LCube.y += Input.GetAxis("PS4_L_Analog_Ver") * sensitivity;
		curPos_LCube.z += Input.GetAxis("PS4_L2") * sensitivity;

		curPos_RCube.x += Input.GetAxis("PS4_R_Analog_Hor") * sensitivity;
		curPos_RCube.y += Input.GetAxis("PS4_R_Analog_Ver") * sensitivity;
		curPos_RCube.z += Input.GetAxis("PS4_R2") * sensitivity;

		lCube.localPosition = curPos_LCube;
		rCube.localPosition = curPos_RCube;
	}
}
