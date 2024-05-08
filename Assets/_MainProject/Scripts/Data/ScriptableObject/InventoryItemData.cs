using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewTask {
	[CreateAssetMenu(fileName = "New InventoryItemData", menuName = "InterviewTask/Inventory Item Data")]
	public class InventoryItemData : ScriptableObject {
		[SerializeField] private Sprite itemSprite; 
		[SerializeField] private string itemName;
		[SerializeField] private int animationId;

		public bool IsLocked { get; private set; }

		public Sprite ItemSprite => itemSprite;
		public string ItemName => itemName;
		public int AnimationId => animationId;
	}
}
