using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewTask {
	public class GameManager : MonoBehaviour {
		private static GameManager instance;
		public static GameManager Instance => instance;

		private const string GOLD_ID = "GOLD_ID";

		public int Gold { 
			get {
				return PlayerPrefs.GetInt(GOLD_ID);
			} private set {
				PlayerPrefs.SetInt(GOLD_ID, value);
			}
		}

		private void Awake() {
			instance = this;

			if(!PlayerPrefs.HasKey(GOLD_ID)) {
				SetGold(1000);
			} else {
				UIGameplayUI.Instance.UpdateGoldText();
			}
		}

		private void SetGold(int amount) {
			Gold = amount;
			UIGameplayUI.Instance.UpdateGoldText();
		}

		public void EarnGold(int amount) {
			Gold += amount;
			UIGameplayUI.Instance.UpdateGoldText();
		}

		public void DeductGold(int amount) {
			Gold -= amount;
			UIGameplayUI.Instance.UpdateGoldText();
		}
	}
}
