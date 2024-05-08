using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewTask {
	public class GameManager : MonoBehaviour {
		private static GameManager instance;
		public static GameManager Instance => instance;

		private const int EARNED_GOLD_PER_SECOND = 10;
		private const int DEFAULT_GOLD = 500;
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
				SetGold(DEFAULT_GOLD);
			} else {
				UIGameplayUI.Instance.UpdateGoldText();
			}

			InvokeRepeating("EarnGoldPerSecond", 1, 1);
		}

		private void EarnGoldPerSecond() {
			EarnGold(EARNED_GOLD_PER_SECOND);
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
