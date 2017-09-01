# VRND-Project Specifications: Design an Apartment
### Starter Project, Instruction and Rubric provided by Udacity
### Developer - Christopher Ohara
#
#
#
## Tasks
###### (1) Create a modern apartment emphasizing the usage of lighting (baked), objects (placement, transformation, scaling, rotation) and being deployable to a smartphone for demonstration.
#
###### (2) Implicit criteria are that the project is aesthetically appealing.
#
#
#
### Platform and Build Specifications
* Platform: Android 7.0, Samsung Galaxy S7
* Unity Version: Unity 5.5.1f
* Google VR SDK for Unity: version 1.0; gvr-unity-sdk-1.0.3
* Java JDK: jdk1.8.0_144

## Screenshots  
![app screenshot](/Screenshot/screenshot01.png)
![app screenshot](/Screenshot/screenshot02.png)


## Installation:
* Download (Clone) Project and unzip 
* In the Starter Project Folder, open the Unity Scene
* Import any desired Assets and Packages
* Window: API Update Import Required --> select "I Made a Backup, Go Ahead"
* Go to File/Build Settings; 
    * Select "Add Open Scene" to the Viewer
    * Select "Android" from the "Platform" Menu and select "Switch Platform"
* Go to Edit/Preferences; Go to "External Tools"
    * Add the appropriate Android SDK
    * Add the appropriate Java JDK
* Go to File/Build Settings; Select Player Settings 
    * In "Other Settings," enable "Virtual Reality Supported"
    * In "Other Settings," add "none" to the VR SDK list (using Unity version pre-5.6)
* Build your scene while having fun!
* Go to File/Build Settings; select "Build and Run"

# TODO Criteria & Specifications:

## Models:
##### Overall Layout

* The overall placement of 3D objects in the scene is reasonable and is visually pleasing. All materials should be assigned, objects should NOT intersect with each other, and objects should NOT be levitating without a reason.

##### Sufficient Detail

* The apartment contains at least 15 models arranged in an interesting way

##### Static Models

* All models are marked as Static (except the globe)

## Google VR:

##### VR Functionality

* When you run the scene, the Cardboard stereoscopic view appears and functions correctly
#
#

## Deployment:

##### Player Settings
#
* Verify that your Player Settings are correct for your device.
* ##### For example:
    * Company Name = Your Name (E.g. MattSonic)
    * Product Name = “Course 2 Project”
    * Default Orientation: ""Landscape Left""
    * Set Bundle Identifier = com.YourName.Course2Project

* For the "Other Settings" section, refer to the Hello World course for proper settings for your device.

* Make sure to indicate in your README.md file whether you are submitting for iOS or Android.

##### Quality Settings
* Delete all of the quality settings but one by clicking the trash can
* Rename the quality setting to “Mobile”
* Set the pixel light count to 0
* Texture Quality: Full Res
* Anti Aliasing: 2x Multi Sampling
* Shadows: Disable Shadows
* Blend Weights: 1 bone
#
* ##### UNCHECK:

    * Soft Particles
    * Realtime rendering probes
    * Billboards face camera position
 
##### Screenshot of App Running on Phone

* Take a screenshot of your phone screen with the app they built running. Ideally, it shows a nice wide view of the apartment.

#
#
## Lighting:

##### Lights

* There are several spotlights and/or area lights

##### Static Lights

* All lights are marked as Static

##### Baked

* All lights are baked and none are realtime (except for one directional light if they choose)

##### Lightmap Settings

* Turn off Precomputed Realtime GI
* Set Directional Mode to Non-Directional
* Turn off Auto baking
* Test different bakes with a Baked Resolution of between 2-5, then do a test bake at 40, then do a final bake with a resolution of 80
* You’ll probably want to activate “Soft Shadows” on each light (so the baked lighting produces nice shadows)
* If you notice lighting artifacts, then switch to uncompressed lightmap. If your app does not perform well any more, you may revert to compressed lightmaps, but you must include in your submission notes what you tried and what happened.
#
#

# Globe:


##### Globe Exists

* A globe should exist and be readily visible in the scene

##### Globe Spins

* When you press the Cardboard button, the globe should spin until you press the button again

##### Globe is Textured
 * The globe should have a texture map of a planet. We provide a texture map of the Earth, but feel free to use your own texture.

#
#

## Appendment:
#
##### How long it took to complete the project.
* Duration: 40 hours (half of the time was related to compatibility issues)
* I was using a newer version of Unity and needed to downgrade
* I had changed the resolution on my smart phone, which caused parallax errors
##### One thing you liked about the project.
* In particular, I enjoy the general architectural aspect of design
* Using the animator and light baking was a good experience as well
* ND projects require students to become professional problem solvers
##### One thing that was particularly challenging about the project.
* As with most ND projects, half of the project is getting your environment to work and deploy
* The total design time was probably only five hours, with the rest searching documentation  



