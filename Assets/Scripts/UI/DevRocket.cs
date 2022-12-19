using System;
using Frameworks;
using UnityEngine;
using UnityEngine.UI;

public class DevRocket : MonoBehaviour
{
    public string Defaultname;
    public GameObject Rocket;

    // Start is called before the first frame update
    private void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(HandleClick);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void HandleClick()
    {
        string[] Preset = Defaultname switch
        {
            "small" => PartLibrary.Smallrocket,
            "medium" => PartLibrary.Mediumrocket,
            "small2" => PartLibrary.Smalltwostage,
            "medium2" => PartLibrary.Mediumtwostage,
            _ => new string[] { }
        };

        ShipBase Builtrocket = PartLibrary.BuildRocket(Preset);
        if (Builtrocket == null) throw new ArgumentNullException(nameof(Builtrocket));

        Rocket.GetComponent<Rocket>().Ship = Builtrocket;
    }
}