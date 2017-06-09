using Models.Abstract;
using UnityEngine;

namespace Assets.Scripts.Game_Machine {

	public class StandardMachine : BasicMachine {
		protected override void CreateHitItem(HitItem item, Transform hole) {
			var hitItem = Instantiate(item, hole.position, Quaternion.identity);
			hitItem.transform.parent = hole;
			hitItem.transform.position += Vector3.down;
		}
	}

}
