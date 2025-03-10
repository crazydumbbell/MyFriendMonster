using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AYellowpaper.SerializedCollections
{
    public class SerializedDictionarySampleTwo : MonoBehaviour
    {
        [SerializedDictionary("Pet", "Info")]
        public SerializedDictionary<string, PetInfo> Pet;

        [System.Serializable]
        public class PetInfo
        {
            public bool IsOwn;
            public float Level;
            public float Damage;
            public float HP;
        }
    }
}