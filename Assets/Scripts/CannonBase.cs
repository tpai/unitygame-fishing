using UnityEngine;
using System.Collections;

public class CannonBase : MonoBehaviour {

	CannonRotation m_CannonRotation;
	public CannonRotation CannonRotation {
		get {
			if (m_CannonRotation == null) {
				m_CannonRotation = GetComponent<CannonRotation>();
			}
			return m_CannonRotation;
		}
	}
}
