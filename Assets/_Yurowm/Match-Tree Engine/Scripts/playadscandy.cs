using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class playadscandy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("LaunchProjectile", 180,180);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LaunchProjectile () {

		Advertisement.Show ();

	}
}
