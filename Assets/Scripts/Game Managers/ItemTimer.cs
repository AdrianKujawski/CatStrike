﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Abstract;
using UnityEngine;

namespace Assets.Scripts.Game_Managers {
	class ItemTimer  : MonoBehaviour {
		public List<HitItem> HitItems;
		public BasicMachine Machine;
		public float Time;

		void Start() {
			InvokeRepeating("DoAction", Time, 1);
		}

		void DoAction() {
			var randomItem = GetRandomHitItem();
			Machine.ShowItem(randomItem);
		}

		HitItem GetRandomHitItem() {
			var hitItem = HitItems[0];
			hitItem.Speed = 5;
			hitItem.EndPosition = 1;
			return hitItem;
		} 
	}
}