using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InterviewTask {
	public class PlayerController : MonoBehaviour {
		[SerializeField] private float speed;
		private Transform playerTransform;
		private Vector2 inputMovement;
		private bool canInteract = false;

		private void Awake() {
			playerTransform = transform;
		}

		private void Update() {
			Vector2 inputVector = inputMovement;
			playerTransform.position += (Vector3)inputVector * speed * Time.deltaTime;

		}

		public void Move(InputAction.CallbackContext context) {
			inputMovement = context.ReadValue<Vector2>();
			Debug.Log(inputMovement);
		}

		public void Interact(InputAction.CallbackContext context) {
			if(canInteract) {
				Interact();
			}
		}

		private void Interact() {
			Debug.Log("Interact!");
		}
	}
}