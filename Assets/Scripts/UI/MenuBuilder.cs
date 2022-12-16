using Frameworks;
using UnityEngine;
using UnityEngine.UI;

public class MenuBuilder : MonoBehaviour
{
    public GameObject ButtonPrefab;
    public GameObject PartButtonPrefab;
    public GameObject Rocket;

    // Start is called before the first frame update
    private void Start()
    {
        Vector3 PartsPosition = transform.Find("Parts").GetComponent<RectTransform>().localPosition;
        PartsPosition.y = (-1 * (Screen.height / 2)) + (transform.Find("Parts").GetComponent<RectTransform>().sizeDelta.y / 2);
        transform.Find("Parts").GetComponent<RectTransform>().localPosition = PartsPosition;

        PartsPosition = transform.Find("PartTypes").GetComponent<RectTransform>().localPosition;
        PartsPosition.y = (-1 * (Screen.height / 2)) + (transform.Find("PartTypes").GetComponent<RectTransform>().sizeDelta.y / 2);
        transform.Find("PartTypes").GetComponent<RectTransform>().localPosition = PartsPosition;

        float btnwidth;
        Transform Parttypestransform = transform.Find("PartTypes");
        GameObject Enginebutton = Instantiate(PartButtonPrefab, Parttypestransform);
        Enginebutton.transform.SetParent(Parttypestransform);
        Enginebutton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Engines";
        btnwidth = Enginebutton.GetComponent<RectTransform>().sizeDelta.x;
        var temppos = Enginebutton.GetComponent<RectTransform>().localPosition;
        temppos.y = 40.5f; // I have no idea why but this number just works.
        Enginebutton.GetComponent<RectTransform>().localPosition = temppos;
        Enginebutton.GetComponent<Button>().onClick.AddListener(() =>
        {
            AddParts(PartLibrary.Engines);
        });

        GameObject Tankbutton = Instantiate(PartButtonPrefab, Parttypestransform);
        Tankbutton.transform.SetParent(Parttypestransform);
        Tankbutton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Tanks";
        temppos = Tankbutton.GetComponent<RectTransform>().localPosition;
        temppos.x += btnwidth + 40;
        temppos.y = 40.5f;
        Tankbutton.GetComponent<RectTransform>().localPosition = temppos;
        Tankbutton.GetComponent<Button>().onClick.AddListener(() =>
        {
            AddParts(PartLibrary.Tanks);
        });

        GameObject Cockpitbutton = Instantiate(PartButtonPrefab, Parttypestransform);
        Cockpitbutton.transform.SetParent(Parttypestransform);
        Cockpitbutton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Cockpits";
        temppos = Cockpitbutton.GetComponent<RectTransform>().localPosition;
        temppos.x += btnwidth * 2 + 80;
        temppos.y = 40.5f;
        Cockpitbutton.GetComponent<RectTransform>().localPosition = temppos;
        Cockpitbutton.GetComponent<Button>().onClick.AddListener(() =>
        {
            AddParts(PartLibrary.Cockpits);
        });

        AddParts(PartLibrary.Tanks);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void AddParts(FuelTank[] Tanks)
    {
        foreach (Transform Child in transform.Find("Parts"))
        {
            // destroy the child
            Destroy(Child.gameObject);
        }

        float Xoffset = -1;
        foreach (FuelTank Tank in Tanks)
        {
            Debug.Log("Creating " + Tank.Base.DisplayName);
            var btn = Instantiate(ButtonPrefab);
            btn.transform.SetParent(transform.Find("Parts"));
            Xoffset++;
            var temppos = btn.GetComponent<RectTransform>().localPosition;
            temppos.x = -390 + (80 * Xoffset);
            temppos.y = 0;
            temppos.z = 0;
            btn.GetComponent<RectTransform>().localPosition = temppos;
            btn.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = Tank.Base.DisplayName;
        }
    }

    private void AddParts(Engine[] Engines)
    {
        foreach (Transform Child in transform.Find("Parts"))
        {
            // destroy the child
            Destroy(Child.gameObject);
        }

        float Xoffset = -1;
        foreach (Engine Engine in Engines)
        {
            Debug.Log("Creating " + Engine.Base.DisplayName);
            var btn = Instantiate(ButtonPrefab);
            btn.transform.SetParent(transform.Find("Parts"));
            Xoffset++;
            var temppos = btn.GetComponent<RectTransform>().localPosition;
            temppos.x = -390 + (80 * Xoffset);
            temppos.y = 0;
            temppos.z = 0;
            btn.GetComponent<RectTransform>().localPosition = temppos;
            btn.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = Engine.Base.DisplayName;
        }
    }

    private void AddParts(Cockpit[] Cockpits)
    {
        foreach (Transform Child in transform.Find("Parts"))
        {
            // destroy the child
            Destroy(Child.gameObject);
        }

        float Xoffset = -1;
        foreach (Cockpit Cockpit in Cockpits)
        {
            Debug.Log("Creating " + Cockpit.Base.DisplayName);
            var btn = Instantiate(ButtonPrefab);
            btn.transform.SetParent(transform.Find("Parts"));
            Xoffset++;
            var temppos = btn.GetComponent<RectTransform>().localPosition;
            temppos.x = -390 + (80 * Xoffset);
            temppos.y = 0;
            temppos.z = 0;
            btn.GetComponent<RectTransform>().localPosition = temppos;
            var tempsize = btn.GetComponent<RectTransform>().sizeDelta;
            tempsize.y = transform.Find("Parts").GetComponent<RectTransform>().sizeDelta.y;
            tempsize.x = tempsize.y;
            btn.GetComponent<RectTransform>().sizeDelta = tempsize;
            btn.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = Cockpit.Base.DisplayName;
        }
    }
}