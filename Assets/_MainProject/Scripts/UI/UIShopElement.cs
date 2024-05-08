using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace InterviewTask {
	public class UIShopElement : MonoBehaviour {
		[SerializeField] private ShopData shopData;

		[SerializeField] private GameObject itemPrefab;

		private Transform myTransform;

		private void Awake() {
			myTransform = transform;
		}

		public void LoadItems() {
			for(int index = 0; index < shopData.ShopItemDatasCount; index++) {
				var shopItemData = shopData.GetShopItemData(index);
				var item = Instantiate(itemPrefab, myTransform);
				var itemName = item.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
				itemName.text = shopItemData.InventoryItemData.ItemName;

				var itemIcon = item.transform.GetChild(1).GetComponent<Image>();
				itemIcon.sprite = shopItemData.InventoryItemData.ItemSprite;

				var itemBuyButton = item.transform.GetChild(2).GetComponent<Button>();
				var itemBuyButtonText = itemBuyButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
				if(shopItemData.InventoryItemData.IsLocked) {
					itemBuyButton.onClick.AddListener(() => {
						if(GameManager.Instance.Gold >= shopItemData.Price) {
							shopItemData.InventoryItemData.IsLocked = false;
							GameManager.Instance.DeductGold(shopItemData.Price);
							itemBuyButtonText.text = "Purchased";
							itemBuyButton.interactable = false;
						}
					});
				} else {
					itemBuyButton.interactable = false;
				}

				itemBuyButtonText.text = shopItemData.InventoryItemData.IsLocked ? $"{shopItemData.Price} Gold" : "Purchased";
			}
		}
	}
}
