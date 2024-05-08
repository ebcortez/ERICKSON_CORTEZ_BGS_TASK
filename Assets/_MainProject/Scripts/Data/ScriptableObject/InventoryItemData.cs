using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewTask {
	[CreateAssetMenu(fileName = "New InventoryItemData", menuName = "InterviewTask/Inventory Item Data")]
	public class InventoryItemData : ScriptableObject {
		[SerializeField] private Sprite itemSprite; 
		[SerializeField] private string itemName;
		[SerializeField] private int animationId;

		[SerializeField] private bool isLocked;
		public bool IsLocked { get => isLocked; set => isLocked = value; }

		public Sprite ItemSprite => itemSprite;
		public string ItemName => itemName;
		public int AnimationId => animationId;
	}
}
