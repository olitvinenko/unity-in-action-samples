using UnityEngine;
using System.Collections;

public class WebTestObject : MonoBehaviour {
	private string _message;

	void Start() {
		_message = "No message yet";
	}

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			Application.ExternalCall("ShowAlert", "Hello out there!");
		}
	}

	void OnGUI() {
		GUI.Label(new Rect(10, 10, 200, 20), _message);
	}

	public void RespondToBrowser(string message) {
		_message = message;
	}
}
