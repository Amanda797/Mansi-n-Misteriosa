using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

	//private Material mat;
	public float speed = 0.05f;

	private MeshRenderer mesh;
	private float OffsetX = 0f;
	private float OffsetY = 0f;

	void Awake(){
		mesh = GetComponent<MeshRenderer> ();
	}

	void Update(){
		//mat.mainTextureOffset.x += 10f;
		OffsetX += speed*Time.deltaTime;
		//mesh.material.mainTextureOffset.Set (OffsetX, OffsetY);
		mesh.material.mainTextureOffset = new Vector2 (OffsetX, OffsetY);
	}
}
