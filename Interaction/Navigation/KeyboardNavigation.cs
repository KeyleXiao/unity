using UnityEngine;

namespace UFZ.Interaction
{
	public class KeyboardNavigation : NavigationBase
	{
		protected override void GetInputs()
		{
			var keyboard = IOC.Core.Instance.Keyboard;
			if (keyboard.IsKeyPressed(KeyCode.W))
				Forward = 1f;
			if (keyboard.IsKeyPressed(KeyCode.S))
				Forward = -1f;
			if (keyboard.IsKeyPressed(KeyCode.A))
				Sideward = -1f;
			if (keyboard.IsKeyPressed(KeyCode.D))
				Sideward = 1f;
			if (keyboard.IsKeyPressed(KeyCode.PageUp))
				Upward = 1f;
			if (keyboard.IsKeyPressed(KeyCode.PageDown))
				Upward = -1f;
			if (keyboard.IsKeyPressed(KeyCode.Q))
				HorizontalRotation = -1f;
			if (keyboard.IsKeyPressed(KeyCode.E))
				HorizontalRotation = 1f;
			if (keyboard.IsKeyPressed(KeyCode.F))
				VerticalRotation = -1f;
			if (keyboard.IsKeyPressed(KeyCode.R))
				VerticalRotation = 1f;

			if (keyboard.IsKeyPressed(KeyCode.LeftShift))
				Running = 1f;
		}
	}
}
