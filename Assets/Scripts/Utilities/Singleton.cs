﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LocationRPG
{
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                }

                DontDestroyOnLoad(_instance);
                return _instance;
            }
        }
    }
}