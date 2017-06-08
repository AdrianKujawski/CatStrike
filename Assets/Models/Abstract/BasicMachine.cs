using UnityEngine;

namespace Models.Abstract {

    public abstract class BasicMachine : MonoBehaviour {
        protected int _holesQty;
        PointCounter _pointCounter;

        protected void Start() {
            _pointCounter = GetComponent<PointCounter>();
            if(_pointCounter == null) Debug.Log("Nie wykrytyto " + typeof(PointCounter));
        }
        
        public abstract void ShowItem(HitItem item);
        public abstract void HideItem();

        public void AddPoint(int value) {
            _pointCounter.AddPoint(value);
        }

        public void ChangePointCounter(int multiplier) {
            _pointCounter.ChangeMultiplier(multiplier);
        }

        public int GetScore() {
            return _pointCounter.Score;
        }
    }

}
