using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace InterviewTask {
	public class ShopKeeperController : MonoBehaviour {
		[SerializeField] private TextMeshPro controlPrompt;

		private void OnTriggerEnter2D(Collider2D collision) {
			if(collision.CompareTag("Player")) {
				controlPrompt.enabled = true;
				collision.GetComponent<PlayerController>().ToggleCanInteract(true);
			}
		}

		private void OnTriggerExit2D(Collider2D collision) {
			if(collision.CompareTag("Player")) {
				controlPrompt.enabled = false;
				collision.GetComponent<PlayerController>().ToggleCanInteract(false);
			}
		}
	}
}
