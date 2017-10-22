using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	private bool opening = false;

	public AudioSource lockedSource;
	public AudioSource openedSource;
	public Key keyObject;

    void Update() {
		if (opening) {
			if (this.gameObject.transform.position.y > 7.5f) {
				opening = false;
			} else {
				this.gameObject.transform.position += new Vector3 (0.0f, 0.1f, 0.0f);
			}
		}
    }

    public void OnDoorClicked() {
		if (this.keyObject.IsKeyCollected()) {
			opening = true;
			openedSource.Play ();
		} else {
			lockedSource.Play ();
		}
    }
}
