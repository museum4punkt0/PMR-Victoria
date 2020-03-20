# pmr-victoria
Unity HoloToolkit Research Project augmenting Victoria Statue at DHM

## Abstract
This Unity HoloLens application was developed together with Museum 4.0, Deutsches Historisches Museum (DHM), and Framefield at FU Berlin as a research project. The application aims to explore different levels of initiative in pure mixed reality (PMR) museum guides. It implements three conditions we labled as guided (system initiative), un-guided (user initiative) and co-active (mixed-initiative). 

## Description


## Installation (Developer Toolchain)

### Unity
1. Download Unity Hub: https://unity3d.com/de/get-unity/download
2. Create a Unity ID: https://id.unity.com/account/new
3. Install Unity Hub and Run.
4. In Unity Hub "Sign In" on the upper right with your Unity ID you just created.
5. Get a (personal) license and activate it by clicking "Activate new license". If the server is unresponsive use "Manual Activation".
6. Click "Installs" on the left menu, then "ADD" at the upper right to add Unity.
7. <b>Important:</b> Select Unity 2018.4.19f1 (LTS) and click "Next".
8. Select the following modules to install:
  - Microsoft Visual Studio Community 2017
  - UWP Build Support (IL2CPP)
  - UWP Build Support (.NET)
  - Documentation
 9. Click "Next" and agree to license terms and "Done".
 10. Get a coffee, as the install will take a while.

### Microsoft Visual Studio Community 2017
1. Download older version of Visual Studio at: https://visualstudio.microsoft.com/de/vs/older-downloads/
2. You will need to create a Microsoft Account or sign in with your existing one.
3. Download Visual Studio Community 2017 (version 15.9)
4. Install following "Workloads":
  - .NET desktop development
  - Universal Windows Platform development
    -- In Optional add: USB Device Connectivity
    -- C++ Universal Windows Platform tools
    -- Graphics debugger and GPU profiler for DirectX
    -- Windows 10 SDK (10.0.17134.0)
  - Game development with Unity
5. Reboot.

### Building the Application
1. Clone this code to your local PC. Download won´t work as git-lfs is used to store the larger asset files.
2. Open Unity Hub and click "Project" and "ADD" the folder (which is a Unity project folder) you just downloaded. This creates a Project which you can assign a specific Unity version.
3. Choose the Unity Version 2018.4.19f1 then click the project name to open the Unity project in the selected version.
4. The Main Unity Project file is located in /Assets/ff/main.unity
5. In Unity click "Folder" > "Build Settings ...".
6. Make the following selections in "Build Settings":
  - Platform > "Universal Windows Platform"
  - Target Device > "HoloLens"
  - Architecture > "x86"
  - Visual Studio Version > "Visual Studio Version 2017"
7. click "Build" and select a folder where to build. Recommended is "App" in the project root.
8. When build is finished click the resulting Visual Studio 2017 project file, which will open VS2017.
9. Select "Release" and "x86" and "Device" to deploy. 

### Known issues
- You need approx. 35GB free HD space for the toolchain
- Windows 10 is required (Win 7 is not working, Win 8 might work).
- You should use Visual Studio 2017
- If you have trouble connecting to the HoloLens via USB, try to ...
  - do a factory reset on the HoloLens
  - install `Windows IP Over USB-x86_en-us.exe`


## Use


## Acknowledgment
