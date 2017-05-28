using System;
using System.Collections;
using System.Collections.Generic;
using Models.Abstract;
using UnityEngine;

public class HitCat : HitItem {

	// Use this for initialization
	new void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	new void Update () {
		base.Update();
	}

	protected override void OnMouseDown() {
		base.OnMouseDown();
		var machine = GameObject.Find("Machine");
		var basicMachine = machine.GetComponent<BasicMachine>();
		basicMachine.AddPoint(5);
	}
}
