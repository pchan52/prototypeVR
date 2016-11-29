using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	Animator anim;

	void Start () 
	{
		anim = gameObject.transform.parent.GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other)
	{
		anim.SetBool("isOpen",true);
	}

	void OnTriggerExit(Collider other)
	{
		anim.SetBool("isOpen",false);
	}
}