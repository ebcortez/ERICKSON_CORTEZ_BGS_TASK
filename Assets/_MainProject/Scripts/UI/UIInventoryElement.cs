using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace InterviewTask {
	public class UIInventoryElement : MonoBehaviour {
		[SerializeField] private InventoryData itemData;
		[SerializeField] private TextMeshProUGUI itemNameText;
		[SerializeField] private Image itemIconImage;
		[SerializeField] private TextMeshProUGUI isLockedNoticeText;

		public Action<InventoryItemData> onItemChanged;

		private const string CURRENT_ITEM_ID = "CURRENT_ITEM_ID";

		private void Start() {
			itemData.CurrentItemId = PlayerPrefs.GetInt(CURRENT_ITEM_ID, 0); 
			UpdateCurrentItem();
		}

		public void NextItem() {
			itemData.CurrentItemId++;
			if(itemData.CurrentItemId >= itemData.InventoryItemDatasCount) {
				itemData.CurrentItemId = 0;
			}

			UpdateCurrentItem();
		}

		public void PreviousItem() {
			itemData.CurrentItemId--;
			if(itemData.CurrentItemId < 0) {
				itemData.CurrentItemId = itemData.InventoryItemDatasCount - 1;
			}

			UpdateCurrentItem();
		}

		private void UpdateCurrentItem() {
			itemNameText.text = itemData.CurrentInventoryItem.ItemName;
			itemIconImage.sprite = itemData.CurrentInventoryItem.ItemSprite;
			isLockedNoticeText.enabled = itemData.CurrentInventoryItem.IsLocked;
			if(!itemData.CurrentInventoryItem.IsLocked) {
				PlayerPrefs.SetInt(CURRENT_ITEM_ID, itemData.CurrentItemId);
				onItemChanged?.Invoke(itemData.CurrentInventoryItem); 
			}
		}
	}
}
