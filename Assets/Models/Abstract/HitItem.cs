using UnityEditor;
using UnityEngine;

namespace Models.Abstract {

    public abstract class HitItem : MonoBehaviour {
        float _distance;
        float _startTime;
        Vector3 _startPosition;
        Vector3 _targerPosition;

        public float Speed;
        public float EndPosition;

        protected virtual void Start() {
            _startPosition = transform.position;
            _targerPosition = transform.position + Vector3.up * EndPosition;
            _distance = Vector3.Distance(_startPosition, _targerPosition);
            _startTime = Time.time;
        }

        protected virtual void Update() {
           var distCovered = (Time.time - _startTime) * Speed;
           var fracJourney = distCovered / _distance;
           transform.position = Vector3.Lerp(_startPosition, _targerPosition, fracJourney);
        }

        protected virtual void OnMouseDown() {
            Destroy(gameObject);
        }
    }

}
