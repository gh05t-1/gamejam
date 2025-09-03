using UnityEngine;
using TMPro;

public class remove : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TM;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextMeshProUGUI TM = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TM.enabled = false;
        }
    }
}
