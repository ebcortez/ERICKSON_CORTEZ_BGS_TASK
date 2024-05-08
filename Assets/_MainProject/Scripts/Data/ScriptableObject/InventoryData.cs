using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace InterviewTask {
	[CreateAssetMenu(fileName = "New InventoryData", menuName = "InterviewTask/Inventory Data")]
	public class InventoryData : ScriptableObject {
		[SerializeField] private InventoryItemData[] inventoryItemDatas;

		[field:NonSerialized] public int CurrentItemId { get; set; }
		public int InventoryItemDatasCount => inventoryItemDatas.Length;
		public InventoryItemData CurrentInventoryItem => inventoryItemDatas[CurrentItemId]; 
	}
}