using UnityEngine;

public class PlayerLantern : MonoBehaviour
{
    public GameObject lanternRangeObject;
    public GameObject[] hiddenTraps;

    public bool isLanternOn = true;

    void Start()
    {
        UpdateLantern();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isLanternOn = !isLanternOn;
            UpdateLantern();
        }
    }

    void UpdateLantern()
    {
        lanternRangeObject.SetActive(isLanternOn);

        foreach (GameObject trap in hiddenTraps)
        {
            trap.GetComponent<SpriteRenderer>().enabled = isLanternOn;
        }
    }
}