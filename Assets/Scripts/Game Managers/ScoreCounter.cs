using System;
using System.Collections;
using System.Collections.Generic;
using Models.Abstract;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : PointCounter {
	public Text ScoreText;

	public override void AddPoint(int value) {
		base.AddPoint(value);
		ScoreText.text = "Score: " + Score;
	}
}

