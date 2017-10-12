# User Interface Design Specialization Capstone

### Developer - Christopher Ohara
#

## Tasks
###### (1) Customize the three different games in the Carnival, and change the placement of the Teddybear. 
#
###### (2) Build and Run on smartphone device, take a screenshot to demonstrate successful build.
#



## Platform and Application Specifications
* Platforms: Android 7.0
* Unity Version: 2017.1.0f3
* VR SDK: Cardboard 1.6


## Screenshots  

![app screenshot](/Screenshot/screenshot01.png)
![app screenshot](/Screenshot/screenshot02.png)


## Installation:

* Download (Clone) Project and unzip 
* In the Starter Project Folder, open the Unity Scene
* Go to File/Build Settings; 
    * Select "Add Open Scene" to the Viewer
    * Select "Android" from the "Platform" Menu and select "Switch Platform"
* Go to Edit/Preferences; Go to "External Tools"
    * Add the appropriate Android SDK
    * Add the appropriate Java JDK
* Go to File/Build Settings; Select Player Settings 
    * In "Other Settings," enable "Virtual Reality Supported"
    * In "Other Settings," add "Cardboard" to the VR SDK list, if not already selected
* Go to File/Build Settings; select "Build and Run"

# TODO Criteria & Specifications:


## General Requirements:

##### Files/folders to be included

* The following files/folders are included:

   * README.md file at the top level of the GitHub repo (or submission folder if submitting zip file).
  * Assets folder of Unity project
  * Project Settings folder

##### Files/folders NOT to be included

* The following files/folders are NOT to included:

    * Library folder
    * Temp folder
#
* NOTE: If submitting GitHub repo, a proper .gitignore must be used to prevent the listed Unity project folders from being included in your submission.

##### Accepted version

* The project is the recommended version of Unity listed on the downloads page.

##### README.md or README.txt

* Create a file called README.md or README.txt at the top level of your submission. In this file, specify the version of GVR and Unity that you used.


## Udacity Carnival:

##### Personalize Scoreboard text

* The Change Scoreboard text in Scene and Game view displays to

* ""FirstName LastName's Scores"" from the original ""Udacity's Scores""

* NOTE: FirstName LastName's must be the students own first and last name.


##### Align Scoreboard Text:
* The font size and position of the Scoreboard text have been adjusted so that in Scene and Game view:

   * No part of the text appears outside of the black area of the Scoreboard.
##### Customize Coin Toss:

* The Min and Max Toss Power of the Carnival Coin Toss component are equal to the values provided in the answer to the Navigation quiz.


##### Customize Wheel of Fortune

* The point values displayed on the wedge of the Wheel of Fortune have been changed so that in both Scene and Game view:

   * The point values are higher for smaller wedges than for larger wedges.
   * The point value text displayed on each wedge fits within the edges of the wedge.

##### Customize Plinko
* The Oscillation Distance on the Carnival Plinko component is set to the value provided in the answer to the Wiring Up Quiz.

##### Position the Teddy Bear

* The Teddy Bear does NOT land on the player (Main Camera) when it drops down as a reward.


## Building the App to Device (Android or iOS):

##### Screenshot of Unity app running on phone

* A Screenshot of the app running on your phone is placed in the top folder of your submission. The screenshot shows any customization you made whether that be your name or changes made to the carnival games.

##### Successful build of the app (apk file for Android and XCode project for iOS)

* A zip file called Build.zip that contains an apk for Android or XCode project for iOS of your project built from Unity. This zip file exists in the top folder of your submission.

### Suggestions to Make Your Project Stand Out!
* ##### NOTE: THESE ARE NOT REQUIRED TO SUBMIT! THESE ARE HERE IF YOU WANT TO PUSH YOUR KNOWLEDGE :)

   * Make the scene more dynamic i.e Add balloons or fireworks behind the tent to make the carnival feel more lively.
   * Add a timer to make the game loop more exciting and competitive.
   * Add a start scene before entering the carnival.


## Appendment:

##### How long it took to complete the project.
* Duration: 15 hours
##### One thing you liked about the project.
* In particular, I enjoyed learning how to adjust 
* ND projects require students to become professional problem solvers
##### One thing that was particularly challenging about the project.
* In this setup, the user needs to deploy each change to the smartphone by rebuilding before they can test and debug the changes they made.



