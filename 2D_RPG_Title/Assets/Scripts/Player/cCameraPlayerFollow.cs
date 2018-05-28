using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cCameraPlayerFollow : MonoBehaviour {

    public float m_CameraDelay = 0.1f;
    public float m_OffsetZ = -100f;
    Vector3 offset;

	// Update is called once per frame
	void LateUpdate ()
    {
        offset = cMain.mPlayerController.transform.position;
        offset.z = m_OffsetZ;

        transform.position = Vector3.Lerp(transform.position, offset, m_CameraDelay);
    }
}
