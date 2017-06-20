using UnityEngine;
using System.Collections;
using System;

public class NetworkService {
	private const string webImage = "http://upload.wikimedia.org/wikipedia/commons/c/c5/Moraine_Lake_17092005.jpg";

	// weather api http://openweathermap.org/api
	private const string jsonApi = "http://api.openweathermap.org/data/2.5/weather?q=Chicago,us";
	private const string xmlApi = "http://api.openweathermap.org/data/2.5/weather?q=Chicago,us&mode=xml";

	private bool IsResponseValid(WWW www) {
		if (www.error != null) {
			Debug.Log("bad connection");
			return false;
		}
		else if (string.IsNullOrEmpty(www.text)) {
			Debug.Log("bad data");
			return false;
		}
		else {	// all good
			return true;
		}
	}

	private IEnumerator CallAPI(string url, Action<string> callback) {
		WWW www = new WWW(url);
		yield return www;
		
		if (!IsResponseValid(www))
			yield break;
		
		callback(www.text);
	}

	public IEnumerator GetWeatherXML(Action<string> callback) {
		return CallAPI(xmlApi, callback);
	}

	public IEnumerator GetWeatherJSON(Action<string> callback) {
		return CallAPI(jsonApi, callback);
	}

	public IEnumerator DownloadImage(Action<Texture2D> callback) {
		WWW www = new WWW(webImage);
		yield return www;
		callback(www.texture);
	}
}
