using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour {

	public Transform pathHolder;
	//Looping through the path Game object, adding a texture/Gizmo to each Child object so it is visible in the Scene
	void OnDrawGizmos() {
		foreach (Transform waypoint in pathHolder) {
			Gizmos.DrawSphere (waypoint.position, .3f);

		}

	}

}
