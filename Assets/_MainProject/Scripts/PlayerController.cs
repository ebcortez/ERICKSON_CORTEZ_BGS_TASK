using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InterviewTask {
	public class PlayerController : MonoBehaviour {
		[SerializeField] private float speed;
		[SerializeField] private float runSpeed;
		[SerializeField] private Animator animator;
		private Rigidbody2D playerRigidbody;
		private Vector2 inputMovement;
		private bool canInteract = false;

		private void Awake() {
			playerRigidbody = GetComponent<Rigidbody2D>();
		}

		private void FixedUpdate() {
			float speedModifier = animator.GetBool(AnimationData.RUN_ANIMATION_NAME) ? runSpeed : speed;
			Vector2 movement = inputMovement.normalized * Time.deltaTime * speedModifier;
			playerRigidbody.MovePosition(playerRigidbody.position + movement);
		}

		public void Move(InputAction.CallbackContext context) {
			inputMovement = context.ReadValue<Vector2>();
			if(Mathf.Abs(inputMovement.normalized.magnitude) > 0) {
				animator.SetFloat(AnimationData.X_DIRECTION_ANIMATION_NAME, Mathf.RoundToInt(inputMovement.x));
				animator.SetFloat(AnimationData.Y_DIRECTION_ANIMATION_NAME, Mathf.RoundToInt(inputMovement.y));
			}
			animator.SetBool(AnimationData.WALK_ANIMATION_NAME, Mathf.Abs(inputMovement.normalized.magnitude) > 0);
		}

		public void Run(InputAction.CallbackContext context) {
			if(context.started) {
				animator.SetBool(AnimationData.RUN_ANIMATION_NAME, true);
			} else if(context.canceled) {
				animator.SetBool(AnimationData.RUN_ANIMATION_NAME, false);
			}
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