using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour {
	public Light myLight;
	public InputActionReference toggleLight;

    void Start() {
		myLight = GetComponent<Light>();

		toggleLight.action.Enable();

		toggleLight.action.performed += (ctx) => {
			if (myLight.color == Color.white) {
				myLight.color = Color.blue;
			} else {
				myLight.color = Color.white;
			}
		};
    }
}