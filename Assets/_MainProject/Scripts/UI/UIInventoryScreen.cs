using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace InterviewTask {
	public class UIInventoryScreen : MonoBehaviour {
		private static UIInventoryScreen instance;
		public static UIInventoryScreen Instance => instance;

		[SerializeField] private Canvas canvas;

		public UIInventoryData uiHatsData, uiHairsData, uiOutfitsData;
		public bool IsShown => canvas.enabled;
		public Action onShow, onHide;

		private void Awake() {
			instance = this;

			if(canvas) canvas = GetComponent<Canvas>();

			Hide();
		}

		public void Show() {
			canvas.enabled = true;
			onShow?.Invoke();
		}

		public void Hide() {
			canvas.enabled = false;
			onHide?.Invoke();
		}
	}
}
