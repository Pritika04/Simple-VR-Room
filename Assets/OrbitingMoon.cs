using UnityEngine;

public class OrbitingMoon : MonoBehaviour {
	public float rotationSpeed = 30f;

    void Update() {
		transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
    }
}
