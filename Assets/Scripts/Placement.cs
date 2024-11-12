using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Placement : MonoBehaviour
{
    public GameObject SpawnableObject;
    public ARSessionOrigin sessionOrigin;
    public ARRaycastManager raycastManager;
    public ARPlaneManager planeManager;

    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();
    private GameObject placedObject;

    void Start()
    {
        Debug.Log("Test log from Start method");
        Debug.Log($"Current SpawnableObject: {SpawnableObject.name}");
    }

    private void Update()
    {
        if (Input.touchCount > 0 && placedObject == null) // Check if no object is placed yet
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("Touch detected");
                bool collision = raycastManager.Raycast(Input.GetTouch(0).position, raycastHits, TrackableType.PlaneWithinPolygon);
                Debug.Log($"Raycast collision: {collision}");
                Debug.Log($"Raycast hits count: {raycastHits.Count}");

                if (collision && !IsButtonPressed())
                {
                    Debug.Log($"Instantiating at: {raycastHits[0].pose.position}");
                    Debug.Log($"Current SpawnableObject: {SpawnableObject.name}");

                    placedObject = Instantiate(SpawnableObject);
                    placedObject.transform.position = raycastHits[0].pose.position;
                    placedObject.transform.rotation = raycastHits[0].pose.rotation;

                    // Apply additional rotation (e.g., 90 degrees around the Y axis)
                    placedObject.transform.Rotate(0, 180, 0);

                    

                    // Disable plane detection after placing the object
                    foreach (var plane in planeManager.trackables)
                    {
                        plane.gameObject.SetActive(false);
                    }
                    planeManager.enabled = false;
                }
            }
        }

        // Implement zoom and move functionality (optional)
        if (placedObject != null)
        {
            // Add your code here to handle zoom and movement
        }
    }

    public bool IsButtonPressed()
    {
        if (EventSystem.current != null && EventSystem.current.currentSelectedGameObject != null)
        {
            return EventSystem.current.currentSelectedGameObject.GetComponent<Button>() != null;
        }
        return false;
    }

    public void Switch(GameObject object12)
    {
        // Destroy the current object if it's placed
        if (placedObject != null)
        {
            Destroy(placedObject);
        }

        SpawnableObject = object12;

        // Re-enable plane detection for placing the new object
        foreach (var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(true);
        }
        planeManager.enabled = true;

        placedObject = null; // Reset placed object
    }

    public void OnBackButtonPressed()
    {
        
        SceneManager.LoadScene("FitnessScene"); 
    }

  
}
