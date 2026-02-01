using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour {
	public Transform player;
	public Transform insidePoint;
	public Transform outsidePoint;
	public bool isInside = true;
	public InputActionReference toggleSwitch;

	void Start() {
		toggleSwitch.action.Enable();
		
		toggleSwitch.action.performed += (ctx) => {
			if (isInside) {
				player.position = outsidePoint.position;
				player.rotation = outsidePoint.rotation;
			} else {
				player.position = insidePoint.position;
				player.rotation = insidePoint.rotation;
			}

			isInside = !isInside;
		};
	}
}