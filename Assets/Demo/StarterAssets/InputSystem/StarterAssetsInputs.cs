using System;
using Cinemachine;
using Demo.Scripts.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

namespace StarterAssets.InputSystem
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

		private bool _slowmoEnabled;
		private bool _freeCameraEnabled;

#if ENABLE_INPUT_SYSTEM
		
		[SerializeField] private FreeCamera freeCamera;
		[SerializeField] private CinemachineBrain cinemachineBrain;

		public void OnToggleCamera()
		{
			_freeCameraEnabled = !_freeCameraEnabled;
			
			freeCamera.enabled = _freeCameraEnabled;
			cinemachineBrain.enabled = !_freeCameraEnabled;
		}

		public void OnSlowmo(InputValue value)
		{
			_slowmoEnabled = !_slowmoEnabled;
			Time.timeScale = _slowmoEnabled ? 0.2f : 1f;
		}
		
		public void OnMove(InputValue value)
		{
			if (_freeCameraEnabled) return;
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if (_freeCameraEnabled) return;
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}
		
		public void OnJump(InputValue value)
		{
			if (_freeCameraEnabled) return;
			JumpInput(value.isPressed);
		}

		public void OnSprint(InputValue value)
		{
			if (_freeCameraEnabled) return;
			SprintInput(value.isPressed);
		}
#endif
		
		public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
}