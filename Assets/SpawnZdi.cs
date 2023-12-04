using UnityEngine;

public class SpawnZdi : MonoBehaviour
{
    Camera cam;
    [SerializeField]
    GameObject wallPrefab;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit info, 100))
            {
                Instantiate(wallPrefab, info.point, Quaternion.identity);
            }
        }
    }
}