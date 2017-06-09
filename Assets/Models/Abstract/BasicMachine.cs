using UnityEngine;

namespace Models.Abstract {

	public abstract class BasicMachine : MonoBehaviour {
		protected Transform _holes;
		protected int _holesQty;

		PointCounter _pointCounter;

		protected void Start() {
			_holes = transform.Find("Holes");
			_holesQty = _holes.childCount;
			_pointCounter = GetComponent<PointCounter>();
			if (_pointCounter == null) Debug.Log("Nie wykrytyto " + typeof(PointCounter));
		}

		internal void ShowItem(HitItem item) {
			if (IsFreeHoles()) {
				var hole = GetFreeHole();
				CreateHitItem(item, hole);
			}
			else
				Debug.Log("Game Over");
		}

		protected virtual void CreateHitItem(HitItem item, Transform hole) { }

		Transform GetFreeHole() {
			Transform hole;
			do {
				hole = _holes.GetChild(Random.Range(0, _holesQty));
			} while (hole.childCount > 0);

			return hole;
		}

		public void AddPoint(int value) {
			_pointCounter.AddPoint(value);
		}

		public void ChangePointCounter(int multiplier) {
			_pointCounter.ChangeMultiplier(multiplier);
		}

		public int GetScore() {
			return _pointCounter.Score;
		}

		bool IsFreeHoles() {
			for (var i = 0; i < _holes.childCount; i++) {
				if (_holes.GetChild(i).childCount == 0) return true;
			}

			return false;
		}
	}

}
