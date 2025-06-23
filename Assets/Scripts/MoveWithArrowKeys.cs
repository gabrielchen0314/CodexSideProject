using UnityEngine;

/// <summary>
/// Simple script to move a target object using arrow key input.
/// </summary>
public class MoveWithArrowKeys : MonoBehaviour
{
	/// <summary>
	/// The object to move.
	/// </summary>
	public GameObject m_Target; // The object to move
	/// <summary>
	/// Movement speed.
	/// </summary>
	public float m_Speed = 5f;	// Movement speed

	/// <summary>
	/// Initializes the target reference.
	/// </summary>
	void Awake()
	{
		if (m_Target == null)
		{
			m_Target = gameObject;
		}
	}

	/// <summary>
	/// Handles input and moves the target each frame.
	/// </summary>
	void Update()
	{
		float _MoveX = 0f;
		float _MoveY = 0f;

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			_MoveX = -1f;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			_MoveX = 1f;
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			_MoveY = 1f;
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			_MoveY = -1f;
		}

		Vector3 _MoveDir = new Vector3(_MoveX, _MoveY, 0f).normalized;
		m_Target.transform.position += _MoveDir * m_Speed * Time.deltaTime;
	}
}
