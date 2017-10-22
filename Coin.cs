using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject CoinPoof;
	public SignPost SignPostScript;

	void Update()
	{
		this.gameObject.transform.rotation = this.gameObject.transform.rotation * Quaternion.Euler (new Vector3 (0.0f, 1.0f, 0.0f));
		this.gameObject.transform.position = this.gameObject.transform.position + new Vector3 (0.0f, Mathf.Sin (Time.time) * Time.deltaTime * 0.25f, 0.0f);
	}	

    public void OnCoinClicked() {
		this.gameObject.GetComponent<Renderer> ().enabled = false; // Hide the object
		Object.Instantiate (CoinPoof, this.gameObject.transform.position, this.gameObject.transform.rotation * Quaternion.Euler(-90.0f, 0.0f, 0.0f));

		AudioSource source = this.gameObject.GetComponent<AudioSource> ();
		source.Play ();

		SignPostScript.UpdateCount ();

		Destroy(this.gameObject, source.clip.length);
    }
}
