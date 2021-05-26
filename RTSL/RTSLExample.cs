using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

using Battlehub.RTCommon;
using Battlehub.RTSL.Interface;


public class RTSLExample : MonoBehaviour
{
    IProject m_project;

    IEnumerator Start()
    {
        m_project = IOC.Resolve<IProject>();

        yield return m_project.OpenProject("My Project");
        yield return m_project.CreateFolder("Scenes/Demo");
    }

    IEnumerator SaveScene()
    {
        ProjectAsyncOperation ao = m_project.Save("Scenes/Demo/Scene", SceneManager.GetActiveScene());
        yield return ao;

        if (ao.Error.HasError)
        {
            Debug.LogError(ao.Error.ToString());
        }
    }

    IEnumerator LoadScene()
    {
        ProjectAsyncOperation ao = m_project.Load<Scene>("Scenes/Demo/Scene");
        yield return ao;

        if (ao.Error.HasError)
        {
            Debug.LogError(ao.Error.ToString());
        }
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.M))
        {
            StartCoroutine(SaveScene());
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            if (m_project.Exist<Scene>("Scenes/Demo/Scene"))
            {
                StartCoroutine(LoadScene());
            }
        }
    }
}