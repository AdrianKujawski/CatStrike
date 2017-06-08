using Models.Abstract;
using UnityEngine;


namespace Game_Machine {

	public class StandardMachine : BasicMachine {
		Transform _holes;
		
		new void Start() {
			base.Start();
			_holes = transform.Find("Holes");
			_holesQty = _holes.childCount;
		}

		public override void HideItem() { }

		//Zabiezpieczyc przez sytuacja, gdy maszyna chce pokazac nowy item
		//na pozycji, gdzie juz item jest pokazywany.
		public override void ShowItem(HitItem item) {
			var hole = _holes.GetChild(Random.Range(0, _holesQty));
			var hitItem = Instantiate(item, hole.position, Quaternion.identity);
			hitItem.transform.position += Vector3.down;
		}
	}

}
