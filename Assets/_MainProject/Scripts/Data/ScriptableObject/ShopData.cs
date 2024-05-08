using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewTask {
	[CreateAssetMenu(fileName = "New ShopData", menuName = "InterviewTask/Shop Data")]
	public class ShopData : ScriptableObject {
		[SerializeField] private ShopItemData[] shopItemDatas;

		public int ShopItemDatasCount => shopItemDatas.Length;
		public ShopItemData GetShopItemData(int index) {
			return shopItemDatas[index];
		}
	}
}
