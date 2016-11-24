using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = gameObject.transform.parent.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		anim.SetBool("isOpen",true);
	}

	void OnTriggerExit(Collider other){
		anim.SetBool("isOpen",false);
	}
}