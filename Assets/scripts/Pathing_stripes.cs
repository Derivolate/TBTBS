﻿using UnityEngine;
using System.Collections;

public class Pathing_stripes : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", GetComponent<Renderer>().material.GetTextureOffset("_MainTex") + new Vector2(0.01f,0));
	}
}