using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewTask {
	public class UIShopScreen : MonoBehaviour {
		private static UIShopScreen instance;
		public static UIShopScreen Instance => instance;

		[SerializeField] private Canvas canvas;

		public UIShopElement uiHatElements, uiHairElements, uiOutfitElements;
		public bool IsShown => canvas.enabled;
		public Action onShow, onHide;

		private void Awake() {
			instance = this;

			if(canvas) canvas = GetComponent<Canvas>();

			uiHatElements.LoadItems();
			uiHairElements.LoadItems();
			uiOutfitElements.LoadItems();

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