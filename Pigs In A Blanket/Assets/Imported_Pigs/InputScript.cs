using UnityEngine;

public class InputScript : MonoBehaviour
{
	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 1.0f;
		var y = Input.GetAxis("Vertical") * Time.deltaTime * 1.0f;

		transform.Translate (x, 0, 0);
		transform.Translate(0, y, 0);
	}
}