using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewTask {
	[CreateAssetMenu(fileName = "New ShopItemData", menuName = "InterviewTask/Shop Item Data")]
	public class ShopItemData : ScriptableObject {
		[SerializeField] private InventoryItemData inventoryItemData;
		[SerializeField] private int price;

		public InventoryItemData InventoryItemData => inventoryItemData;
		public int Price => price;
	}
}