using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour {

	public float speed = 5;
	public float waitTime = .3f;
	public float turnSpeed  = 90; //90 degrees per second

	public Transform pathHolder;

	void Start() {

		// array of all points in the path, the size depends on the chil dren within the path
		Vector3[] waypoints = new Vector3[pathHolder.childCount];

		for (int i = 0; i < waypoints.Length; i++) {
				waypoints [i] = pathHolder.GetChild (i).position;
				waypoints [i] = new Vector3(waypoints[i].x, transform.position.y, waypoints[i].z);
			}
		StartCoroutine (FollowPath (waypoints));

	}

	//follow path Coroutine, with an array called way points.
	IEnumerator FollowPath(Vector3[] waypoints) {
		//checks to make sure guard is at the first waypoint
		transform.position = waypoints [0];
		 //integer to keep track of the index of waypoints that the guard is moving towards

		int targetWaypointIndex = 1;
		Vector3 targetWaypoint = waypoints [targetWaypointIndex];
		//guard faces the waypoint intially
		transform.LookAt(targetWaypoint);
		//moves guard to target waypoint constantly, depending on the speed float variable
		while (true) {
			transform.position = Vector3.MoveTowards(transform.position, targetWaypoint, speed * Time.deltaTime);
			//Once target way point is reached, wait, then move
			if (transform.position == targetWaypoint) {
				//included a mod (modulo) operator when targetwaypointindex is equal to the waypoints it will return to 0
				targetWaypointIndex = (targetWaypointIndex + 1 ) % waypoints.Length;
				targetWaypoint = waypoints [targetWaypointIndex];
				yield return new WaitForSeconds (waitTime);
				yield return StartCoroutine (TurnToFace(targetWaypoint));
			}
			//yield for one frame for each iteration of the while loop
			yield return null;
		}

	}
	// turning towards way point before moving to the next one
	IEnumerator TurnToFace(Vector3 lookTarget) {
		Vector3 dirToLookTarget = (lookTarget - transform.position).normalized;
		float targetAngle = 90 - Mathf.Atan2(dirToLookTarget.z, dirToLookTarget.x) * Mathf.Rad2Deg;
		//rotate to target over time
		//while loop will stop running once the guard is facing the look target
		while (Mathf.DeltaAngle(transform.eulerAngles.y, targetAngle) > 0.05f) {
			float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, targetAngle, turnSpeed * Time.deltaTime);
			transform.eulerAngles = Vector3.up * angle;
			yield return null;
		}

	}

	//Looping through the path Game object, adding a Line and Texture to each Child object so it is visible in the Scene
	void OnDrawGizmos() {
		Vector3 startPosition = pathHolder.GetChild(0).position;
		Vector3 previousPosition = startPosition;

		foreach (Transform waypoint in pathHolder) {
			Gizmos.DrawSphere (waypoint.position, .3f);
			Gizmos.DrawLine (previousPosition, waypoint.position);
			previousPosition = waypoint.position;
		}
			Gizmos.DrawLine(previousPosition, startPosition);

	}

}
