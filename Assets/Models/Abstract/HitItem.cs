using UnityEditor;
using UnityEngine;

namespace Models.Abstract {

    public abstract class HitItem : MonoBehaviour {
        float _distance;
        float _startTime;
        Vector3 _startPosition;
        Vector3 _targerPosition;
        State _moveState = State.Up;

        public static float Speed = 5;
        public static float EndPosition = 1;
        public float TimeToHide = 1;
	    public int ScoreValue = 1;

        protected virtual void Start() {
            SetParameterToMove(transform.position + Vector3.up * EndPosition);
        }

        protected virtual void Update() {
            switch (_moveState) {
                case State.Stay: break;
                case State.Up:
                    MoveItem();
                    if (transform.position.y >= _targerPosition.y) {
                        _moveState = State.Stay;
                        InvokeRepeating("DecrementTimeToHide", TimeToHide, 1);
                    }

                    break;
                case
                State.Down:
                    MoveItem();
                    if (transform.position.y <= _targerPosition.y) {
                        Destroy(gameObject);
                    }
                    break;
            }
        }

        void DecrementTimeToHide() {
            TimeToHide--;
            if (TimeToHide >= 1) return;

            SetParameterToMove(transform.position + Vector3.down * EndPosition);
            _moveState = State.Down;
        }

        void MoveItem() {
            var distCovered = (Time.time - _startTime) * Speed;
            var fracJourney = distCovered / _distance;
            transform.position = Vector3.Lerp(_startPosition, _targerPosition, fracJourney);
        }

        void SetParameterToMove(Vector3 targetPosition) {
            _startPosition = transform.position;
            _targerPosition = targetPosition;
            _distance = Vector3.Distance(_startPosition, _targerPosition);
            _startTime = Time.time;
        }

       
        protected virtual void OnMouseDown() {
            Destroy(gameObject);
        }


        enum State {
            Up,
            Down,
            Stay
        }
    }

}
