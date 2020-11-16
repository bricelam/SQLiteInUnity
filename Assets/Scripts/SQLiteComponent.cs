using System.Collections;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using UnityEngine;
using UnityEngine.UI;

public class SQLiteComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var text = GetComponent<Text>();
        text.text = new SqliteConnection().ServerVersion;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
