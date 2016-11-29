using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour 
{
	[SerializeField] AudioClip audioclip;
	[SerializeField] GameObject bullet;
	AudioSource audioSource;

	void Start () 
	{
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = audioclip;
	}
	
	void Update () 
	{
		if ( Input.GetButtonDown("Fire1") ) 
		{
			Shot ();
			//bullet移動のメソッドを呼ぶ
		} 
	}

	void Shot()
	{
		audioSource.Play();
		var newBullet = Instantiate(bullet);
		newBullet.transform.position = transform.position;
		newBullet.transform.rotation = transform.rotation;
	}
}
