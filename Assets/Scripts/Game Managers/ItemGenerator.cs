using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Abstract;
using UnityEngine;

namespace Assets.Scripts.Game_Managers {
	class ItemGenerator  : MonoBehaviour {
		public List<HitItem> HitItems;
		public BasicMachine Machine;
		public float Time = 1;

		void Start() {
			InvokeRepeating("DoAction", 1, Time);
		}

		void DoAction() {
			var randomItem = GetRandomHitItem();
			Machine.ShowItem(randomItem);
		}

		HitItem GetRandomHitItem() {
			var result = UnityEngine.Random.Range(1, 100);

			return result <= 20 ? HitItems[1] : HitItems[0];
		} 
	}
}
