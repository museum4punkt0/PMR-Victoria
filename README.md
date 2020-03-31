# pmr-victoria
Unity HoloToolkit research project augmenting Victoria statue at DHM

## Abstract
This Unity HoloLens application was developed together with museum4punkt0, Deutsches Historisches Museum (DHM), and Framefield GmbH at FU Berlin for a research project. The application aims to explore different levels of initiative in pure mixed reality (PMR) museum guides. It implements three conditions of initiative we labled as guided (system initiative), un-guided (user initiative) and co-active (mixed-initiative).
The project museum4punkt0 - Digital Strategies for the Museum of the Future, is funded by the Federal Government Commissioner for Culture and the Media in accordance with a resolution issued by the German Bundestag (Parliament of the Federal Republic of Germany). Further information: www.museum4punkt0.de/en/  

## Description
This HoloLens application is an inquiry into the design space of pure mixed reality (PMR) in the context of museum interpretation. The application was developed to reflect constructs such as presence, object presence, agency, co-activity and initiative in PMR. Several interaction techniques are implemented to create the sense of being 'there' als well as the sense of various levels of initiative. To understand if users can sense those experiential variations, three conditions are implemented. While the content of museum interpretation stays the same, the form of (inter)activity with the guide varies. Our hypothesis is that various levels of initiative may have an impact on rememberance and experience. In addition we are interested in whether the real exhibit loses of gains realness or attention in such a PMR environment.  

## Installation (Developer Toolchain)

### System requirements
- Microsoft HoloLens 1 Developer Edition (Consumer edition untested)
- Windows 10 is required (Win 7 is not working, Win 8 might work)
- Approx. 35GB free HD space for the toolchain is needed.
- Visual Studio Community 2017 version 15.9 available at https://visualstudio.microsoft.com/de/vs/older-downloads/
- Unity 2018.4.19f1 (LTS) available through Unity Hub at https://unity3d.com/de/get-unity/download

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
    - In Optional add: 
    - USB Device Connectivity
    - C++ Universal Windows Platform tools
    - Graphics debugger and GPU profiler for DirectX
    - Windows 10 SDK (10.0.17134.0)
  - Game development with Unity
5. Reboot.

### Building the Application
1. Clone this code to your local PC. Download won´t work as git-lfs is used to store the larger asset files.
2. Open Unity Hub and click "Project" and "ADD" the folder (which is a Unity project folder) you just downloaded. This creates a Project which you can assign a specific Unity version.
3. Choose the Unity Version 2018.4.19f1 then click the project name to open the Unity project in the selected version. Unity will update project to selected version.
4. The Main Unity Project file is located in /Assets/ff/main.unity
5. In Unity click "Folder" > "Build Settings ...".
6. Make the following selections in "Build Settings":
  - Platform > "Universal Windows Platform"
  - Target Device > "HoloLens"
  - Architecture > "x86"
  - Visual Studio Version > "Visual Studio Version 2017"<br>
  <b>Important:</b> After switching the built platform a restart of Unity is needed. Otherwise the TapToPlace won't work.
7. Click "Build" and select a folder where to build. Recommended is "App" in the project root.
8. When build is finished click the resulting Visual Studio 2017 project file in the App folder, which will open VS2017.
9. Select "Release" and "x86" and "Device" to deploy.
10. Connect the Hololens via USB and switch it on.
11. Deploy.

### Known issues
- If you have trouble connecting to the HoloLens via USB, try to ...
  - do a factory reset on the HoloLens
  - install `Windows IP Over USB-x86_en-us.exe`

## Use (Hololens)
When deployed to the HoloLens, open the App by clicking the Icon. The application uses voice commands, so you have to accept the microphone use requested in the pop-up dialogue. The application starts in configuration mode. Air-Tap the Victoria mesh and map it to the real statue in the DHM. You can use the configuration menu on the right to translate, scale and rotate the statue. To start one of the conditions you say "Start alpha!" for the guided condition, "Start bravo!" for the un-guided condition and "Start charly!" for the mixed initiative version. The experience will start as soon as your gaze is on the statue. To abort the tour say "Cancel Tour!". To go back to the configuration environment say "Admin Mode!". All three tours can also be started by Air-Tap on one of the letters A, B or C.
The application is automatically recording a 6 DOF coordinate list in a speed of 20 samples per second. The logfile can be accessed via Hololens Device Portal in the application folder.

## Use (Unity)
When testing the application in Unity, voice commands can be startet via number keys. The '1' key will start the guided mode, '2' Un-guided, and '3' mixed initiative mode. To avoid waiting times during content play the 'q' key can be pressed to allow premature content selection. However, guide formats can also be selected via 'configuration menu' buttons 'A', 'B', 'C' similar to the use when deployed on HoloLens.

## Acknowledgment
Prof. Dr. rer. nat. Claudia Müller-Birn (FU-Berlin)<br>
Dr. Patrick Tobias Fischer (FU Berlin)<br>
Kartin Glinka (museum4punkt0)<br>
Dr. Silke Krohn (museum4punkt0)<br>
Thomas Mann (Framefield GmbH)<br>
Dominik Ganghofer (Framefield GmbH)<br>

## License
This application is licensed under MIT License (/LICENSE)
HoloToolkit is licensed under the MIT License (/Assets/vendor/HoloToolkit/License.txt)
