using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace FrozenPhoenix.Utilities
{
    public static class HelperMethods
    {
        public static void FPSLogger(string message, bool isActive)
        {
            if (isActive)
            {
                Debug.Log(message);
            }
        }

        // public static void CheckAndAssignComponent<T>(ref T componentToCheck, GameObject objectRequesting)
        //     where T : MonoBehaviour
        // {
        //     var component = objectRequesting.GetComponent<T>();
        //     if (component == null)
        //         Debug.LogError($"{typeof(T)} is null on the {objectRequesting.transform.name}");
        //     else
        //         componentToCheck = component;
        // }

        public static int RoundToInt(float value)
        {
            return (int) Math.Round(value, MidpointRounding.AwayFromZero);
        }
        
        public static void CheckAndAssignComponent<T>(ref T componentToCheck, GameObject objectRequesting, bool throwError = true)
        {
            var component = objectRequesting.GetComponent<T>();
            if (component == null)
            {
                if (throwError)
                    Debug.LogError($"{typeof(T)} is null on the {objectRequesting.transform.name}");
                else
                    Debug.Log($"{typeof(T)} is null on the {objectRequesting.transform.name}");
            }
            else
                componentToCheck = component;
        }
        
        public static void TryCheckAndAssignComponent<T>(ref T componentToCheck, GameObject objectRequesting)
        {
            objectRequesting.TryGetComponent<T>(out var component);
            if (component == null)
                Debug.LogError($"{typeof(T)} is null on the {objectRequesting.transform.name}");
            else
                componentToCheck = component;
        }
        
        public static void CheckAndAssignComponentInChild<T>(ref T componentToCheck, GameObject objectRequesting, bool throwError = true)
        {
            var component = objectRequesting.GetComponentInChildren<T>();
            if (component == null)
            {
                if (throwError)
                    Debug.LogError($"{typeof(T)} is null on the {objectRequesting.transform.name}");
                else
                    Debug.Log($"{typeof(T)} is null on the {objectRequesting.transform.name}");
            }
            else
                componentToCheck = component;
        }
        
        public static void CheckAndAssignComponentsInChildren<T>(ref T[] componentToCheck, GameObject objectRequesting, bool throwError = true)
        {
            var components = objectRequesting.GetComponentsInChildren<T>();
            if (components.Length < 1)
            {
                if (throwError)
                    Debug.LogError($"{typeof(T)} is null on the {objectRequesting.transform.name}");
                else
                    Debug.Log($"{typeof(T)} is null on the {objectRequesting.transform.name}");
            }
            else
                componentToCheck = components;
        }

        public static void CheckAndAssignComponent<T>(ref List<T> componentToCheck, GameObject objectRequesting, bool throwError = true)
        {
            var component = objectRequesting.GetComponents<T>();
            if (component == null)
            {
                if (throwError)
                    Debug.LogError($"{typeof(T)} is null on the {objectRequesting.transform.name}");
                else
                    Debug.Log($"{typeof(T)} is null on the {objectRequesting.transform.name}");
            }
            else
                componentToCheck = component.ToList();
        }

        public static void CheckAndAssignComponent<T>(ref T[] componentToCheck, GameObject objectRequesting, bool throwError = true)
        {
            var component = objectRequesting.GetComponents<T>();
            if (component == null)
            {
                if (throwError)
                    Debug.LogError($"{typeof(T)} is null on the {objectRequesting.transform.name}");
                else
                    Debug.Log($"{typeof(T)} is null on the {objectRequesting.transform.name}");
            }
            else
                componentToCheck = component;
        }
        
        public static void CheckAndAssignComponentInParent<T>(ref T componentToCheck, GameObject objectRequesting, bool throwError = true)
        {
            var component = objectRequesting.GetComponentInParent<T>();
            if (component == null)
            {
                if (throwError)
                    Debug.LogError($"{typeof(T)} is null on the {objectRequesting.transform.name}");
                else
                    Debug.Log($"{typeof(T)} is null on the {objectRequesting.transform.name}");
            }
            else
                componentToCheck = component;
        }

        public static void FindAndAssignComponent<T>(ref T componentToFind, GameObject objectRequesting, bool throwError = true)
        {
            var component = GameObject.FindObjectOfType<T>();
            if (component == null)
            {
                if (throwError)
                    Debug.LogError($"{typeof(T)} is null on the {objectRequesting.transform.name}");
                else
                    Debug.Log($"{typeof(T)} is null on the {objectRequesting.transform.name}");
            }
            else
                componentToFind = component;
        }
        
        public static Camera FindAndAssignMainCamera()
        {
            var camera = Camera.main;
            if (camera == null)
                Debug.LogError($"Main Camera is null");
            else
                return camera;
            return null;
        }

    }
}