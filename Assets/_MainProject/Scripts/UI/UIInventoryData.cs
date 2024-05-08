using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace InterviewTask {
	public class UIInventoryData : MonoBehaviour {
		[SerializeField] private InventoryData itemData;
		[SerializeField] private TextMeshProUGUI itemNameText;
		[SerializeField] private Image itemIconImage;

		public Action<InventoryItemData> onItemChanged;

		private void Start() {
			UpdateCurrentItem();
		}

		public void NextItem() {
			itemData.CurrentItemId++;
			if(itemData.CurrentItemId >= itemData.InventoryItemDatas.Length) {
				itemData.CurrentItemId = 0;
			}

			UpdateCurrentItem();
		}

		public void PreviousItem() {
			itemData.CurrentItemId--;
			if(itemData.CurrentItemId < 0) {
				itemData.CurrentItemId = itemData.InventoryItemDatas.Length - 1;
			}

			UpdateCurrentItem();
		}

		private void UpdateCurrentItem() {
			itemNameText.text = itemData.CurrentInventoryItem.ItemName;
			itemIconImage.sprite = itemData.CurrentInventoryItem.ItemSprite;
			onItemChanged?.Invoke(itemData.CurrentInventoryItem);
		}
	}
}
