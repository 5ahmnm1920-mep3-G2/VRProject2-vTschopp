# Mystery Physics

:bangbang: **This game is a new attempt of [this project](https://github.com/5ahmnm1920-mep3-G2/VRProject-vTschopp)
because the Oculus Quest didn't work well with my system.**

Mystery Physics is a virtual reality game developed in [Unity](http://unity.com/) for the [VIVE](https://www.vive.com/).
The goal of the game is to solve a puzzle by manipulating fundamental physical principles like gravity* and magnetism.

:bangbang: **This game is only a proof of concept and not yet performant!**

**Only feature to be implemented.*

## Progress
:squirrel: **40 %**

## Final product
The player *should* control a platform only with moving the controller in the right direction.
In order to reach the other side, it is necessary for the player to collect energy cells.

- [Screenshot 1](https://github.com/5ahmnm1920-mep3-G2/VRProject2-vTschopp/blob/master/Presentation/Images/screenshot-1.png)
- [Screenshot 2](https://github.com/5ahmnm1920-mep3-G2/VRProject2-vTschopp/blob/master/Presentation/Images/screenshot-2.png)
- [Concept 1](https://github.com/5ahmnm1920-mep3-G2/VRProject2-vTschopp/blob/master/Presentation/Images/concept-1.jpg)
- [Concept 2](https://github.com/5ahmnm1920-mep3-G2/VRProject2-vTschopp/blob/master/Presentation/Images/concept-2.jpg)

## How to build from source
:bangbang: **The project is not ready to be build yet!**

Clone the repository, open the project with Unity 2019.1.14f1 and
[punch the build button](https://media.giphy.com/media/wNlks0ID1igO4/giphy.gif).

## Development and target platforms
- **Unity 2019.1.14f1** on macOS Catalina
  - Scripting Runtime: **.NET 4.x Equivalent**
  - API-Level: **.NET Standard 2.0**
- **Visual Studio** for Mac Community (latest version)
- Developed for the **[VIVE](https://www.vive.com/)**

## Logbook
**Before 15th of January 2020** <br>
Several severe problems with the Oculus Quest occured in combination with my system.
Especially, I wasn't able to connect the headset with my MacBook Pro.
Downloading [Android Studio](https://developer.android.com/studio/index.html) didn't help either.
I watched a few tutorials on YouTube (e.g. [How to make an OCULUS QUEST game](https://www.youtube.com/watch?v=qiJpjnzW-mw)
by [Valem](https://www.youtube.com/channel/UCPJlesN59MzHPPCp0Lg8sLw). I failed successfully and wasted hours.

*For more information please visit the [old project](https://github.com/5ahmnm1920-mep3-G2/VRProject-vTschopp).* :link:

**22nd of January 2020** <br>
Restart of the project with the VIVE.
I used a [template](https://github.com/5ahmnm1920-mep3-G2/unity-2019.1.14f1-3D-template)
to create the initial project, renamed the neccessary things and updated the README.md and .gitignore files.
I also downloaded the [SteamVR Plugin](https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647)
and imported it into the project. After that, I implemented the basic VR controls.
A test with the headset was successful. :ok_man:

**28th and 29th of January 2020** <br>
I made a simple level with cubes, added the teleport feature and made a power cell prefab. Instances of this prefab
are spawning randomly on the map, controlled by a simple script in combination with two empties which define the spawn area.
I learned how to use a [slider](https://answers.unity.com/questions/186832/slider-bar-in-inspector.html) in the
Unity inspector - quite a handy feature! :cool:

**5th of February 2020** <br>
A spinning globe was added. Yeah, thats all. :rocket:

**By 19th of February 2020** <br>
[Standard Assets](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2017-3-32351)
were added for the first-personen controller, thats because during semester break I had no access to a VR system.
Also a problem with the world scale emerged: apparently, VR is using a smaller scale than the classical approach. :ant:

## Resume
The project was no success at all. First of all, to develop for VR but without a stationary virtual reality system
is pure madness and difficult to manage. Secondly, a project this big during a phase of constant stress (diploma project)
is hard to pull off. That's one reason, why this project didn't finish. Other reasons are the difficulties I
encounterd during development - for more information see the logbook. :hatched_chick:

## Tutorials and Docs
- [How to make an OCULUS QUEST game](https://www.youtube.com/watch?v=qiJpjnzW-mw)
by [Valem](https://www.youtube.com/channel/UCPJlesN59MzHPPCp0Lg8sLw)
- Official Oculus Quest documentation
  - [Oculus Unity Getting Started Guide](https://developer.oculus.com/documentation/quest/latest/concepts/book-unity-gsg/)
  - [Tutorial: Build Your First VR App](https://developer.oculus.com/documentation/quest/latest/concepts/unity-tutorial/)
  - [Preparing for Android Development](https://developer.oculus.com/documentation/quest/latest/concepts/unity-mobileprep/)

## External resources
- [SteamVR Plugin](https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647)
- [Standard Assets](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2017-3-32351)

## License
This project is licensed under the BSD 2-Clause License - see the [LICENSE.md](LICENSE.md) file for more information.

*Made with :heart: in Salzburg, Austria.*
