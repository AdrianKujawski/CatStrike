using System.Collections;
using System.Collections.Generic;
using Models.Abstract;
using UnityEngine;

namespace Bonuses {

	public class MultiplyBonus : HitItem, IBonus {
		public BasicMachine Machine2;

		public float BonusTime = 10f;
		public int Multiply = 2;

		protected override void Start() {
			base.Start();
			var machine = GameObject.Find("Machine");
			var basicMachine = machine.GetComponent<BasicMachine>();
			if (basicMachine != null) {
				Machine = basicMachine;
			}
		}

		// Update is called once per frame
		protected override void Update() {
			base.Update();
			if (Input.GetMouseButtonUp(0)) {
				Boost();
				Destroy(this);
			}
		}

		public BasicMachine Machine { get; set; }

		public void Boost() {
			Machine.ChangePointCounter(Multiply);
		}


	}

}