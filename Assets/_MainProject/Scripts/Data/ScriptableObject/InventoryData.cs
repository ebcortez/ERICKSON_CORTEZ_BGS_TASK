using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewTask {
	[CreateAssetMenu(fileName = "New InventoryData", menuName = "InterviewTask/Inventory Data")]
	public class InventoryData : ScriptableObject {
		[SerializeField] private InventoryItemData[] inventoryItemDatas;

		public InventoryItemData[] InventoryItemDatas => inventoryItemDatas;
		public int CurrentItemId { get; set; }
		public InventoryItemData CurrentInventoryItem => inventoryItemDatas[CurrentItemId]; 
	}
}