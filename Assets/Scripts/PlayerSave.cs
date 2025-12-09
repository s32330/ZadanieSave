using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSave : MonoBehaviour
{
    //przykladowe dane
    public int health = 100;
    public int coins = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.L)) {
            Load();
        }

        public void Save()
    {
        SaveData data = new SaveData();
        data.health = health;
        data.coins = coins;
        data.position = new float[]
            {transform.position.x,
            transform.position.y,
            transform.position.z

            };
        //zapisuje dane za pomoca savesystem
        SaveSystem.Save(data);
        Debug.Log("Game Saved");
    }

    public void Load()
        {
        SaveData data = SaveSystem.Load();
        if (data != null) {
            Debug.LogWarning("No save data found");
            return;
        }
}
