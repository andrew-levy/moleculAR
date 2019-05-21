
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpinLogic : MonoBehaviour {



		float pointerY;
		float f_lastX = 0.0f;
		float f_difX = 0.5f;
		float f_steps = 0.0f;
		int i_direction = 1;
		void Start()
		{
			pointerY = Input.GetAxis("Mouse Y");
		}
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				f_difX = 0.0f;
			}
			else if (Input.touchCount > 0)
			{
				pointerY = Input.touches[0].deltaPosition.y;
				f_difX = Mathf.Abs(f_lastX - pointerY);
				var touch = Input.GetTouch(0);
				if (touch.position.x > Screen.width / 2)
				{
					// Right
					if (f_lastX < Input.GetAxis("Mouse Y"))
					{
						i_direction = 1;
						transform.Rotate(Vector3.forward, f_difX * Time.deltaTime);
					}
					if (f_lastX > Input.GetAxis("Mouse Y"))
					{
						i_direction = -1;
						transform.Rotate(Vector3.forward, -f_difX * Time.deltaTime);
					}
				}
				else if (touch.position.x < Screen.width / 2)
				{
					// Left
					if (f_lastX < Input.GetAxis("Mouse Y"))
					{
						i_direction = -1;
						transform.Rotate(Vector3.forward, -f_difX * Time.deltaTime);
					}
					if (f_lastX > Input.GetAxis("Mouse Y"))
					{
						i_direction = 1;
						transform.Rotate(Vector3.forward, f_difX * Time.deltaTime);
					}
				}
				f_lastX = -pointerY;
				f_difX = 500f;
				Debug.Log(f_difX);
			}
			else
			{
				if (f_difX > 0.5f) f_difX -= 1f;
				if (f_difX < 0.5f) f_difX += 1f;
				transform.Rotate(Vector3.forward, f_difX * i_direction * Time.smoothDeltaTime);
			}
		}
}