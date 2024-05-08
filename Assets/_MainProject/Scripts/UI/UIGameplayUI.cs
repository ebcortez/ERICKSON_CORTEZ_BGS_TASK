using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace InterviewTask {
	public class UIGameplayUI : MonoBehaviour {
		private static UIGameplayUI instance;
		public static UIGameplayUI Instance => instance;

		[SerializeField] private TextMeshProUGUI goldText;

		private void Awake() {
			instance = this;
		}
		
		public void UpdateGoldText() {
			goldText.text = $"GOLD: {GameManager.Instance.Gold}";
		}
	}
}
