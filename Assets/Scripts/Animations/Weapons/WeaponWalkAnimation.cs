﻿using Controls.Data;
using UnityEngine;

namespace Animations.Weapons
{
	public sealed class WeaponWalkAnimation : MonoBehaviour
	{
		public void Construct(Animator animator, CharacterControlsData data)
		{
			_animator = animator;
			_data = data;
		}

		private void Update()
		{
			_animator.SetBool(MovingId, _data.Direction.HasValue);
			if (!_data.Direction.HasValue) return;

			var movementSpeed = _data.Direction.Value.magnitude;
			_animator.SetFloat(MovementSpeedId, movementSpeed);
		}

		private Animator _animator;
		private CharacterControlsData _data;
		private static readonly int MovingId = Animator.StringToHash("Moving");
		private static readonly int MovementSpeedId = Animator.StringToHash("Movement Speed");
	}
}