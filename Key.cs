using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Key : MonoBehaviour 
{
	private bool keyCollected = false;
	private AudioSource audioSource = null;

	public GameObject KeyPoof;

	void Start()
	{
		this.audioSource = this.gameObject.GetComponent<AudioSource> ();
	}

	void Update()
	{
		this.gameObject.transform.rotation = this.gameObject.transform.rotation * Quaternion.Euler (new Vector3 (0.0f, 0.0f, 1.0f));
		this.gameObject.transform.position = this.gameObject.transform.position + new Vector3 (0.0f, Mathf.Sin (Time.time) * Time.deltaTime * 0.25f, 0.0f);
	}

	public void OnKeyClicked()
	{
		keyCollected = true;

		this.gameObject.GetComponent<Renderer> ().enabled = false; // Hide the key
		Object.Instantiate(KeyPoof, this.gameObject.transform.position, this.gameObject.transform.rotation);

		this.audioSource.Play ();
		Destroy (this.gameObject, this.audioSource.clip.length);
    }

	public bool IsKeyCollected()
	{
		return this.keyCollected;
	}
}
