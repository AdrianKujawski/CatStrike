using UnityEngine;

namespace Models.Abstract {

    public abstract class PointCounter : MonoBehaviour {
        public int Multiplier;

        [SerializeField]
        public int Score { get; protected set; }

        protected virtual void Start() {
            Multiplier = 1;
            Score = 0;
        }

        public virtual void AddPoint(int value) {
            Score += value * Multiplier;
        }

        //Zmiana mnożnika powinna być przez jakiś określony czas
        public void ChangeMultiplier(int value) {
            Multiplier *= value;
            //Czy raczej
            // _multiplier += value;
            Debug.Log("Teraz mnoznik = " + Multiplier);
        }
    }

}
