using Models.Abstract;
using UnityEngine;


namespace Assets.Scripts {

	public class HitCat : HitItem {

		protected override void OnMouseDown() {
			base.OnMouseDown();
			var machine = GameObject.Find("Machine");
			var basicMachine = machine.GetComponent<BasicMachine>();
			basicMachine.AddPoint(ScoreValue);
		}
	}

}
