using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePrefs : MonoBehaviour {

	public int CurrentNumber;
	public int PreviousNumber;

	void Start () {

		if (PlayerPrefs.GetInt("storedNumber") != null) PreviousNumber = PlayerPrefs.GetInt("storedNumber");

		CurrentNumber = Random.Range (0, 999);

		PlayerPrefs.SetInt ("storedNumber", CurrentNumber);
	}
}
