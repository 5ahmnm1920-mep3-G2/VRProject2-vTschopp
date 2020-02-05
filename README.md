# Mystery Physics

:bangbang: **This game is a new attempt of [this project](https://github.com/5ahmnm1920-mep3-G2/VRProject-vTschopp)
because the Oculus Quest didn't work well with my system.**

Mystery Physics is a virtual reality game developed in [Unity](http://unity.com/) for the [VIVE](https://www.vive.com/).
The goal of the game is to solve a puzzle by manipulating fundamental physical principles like gravity* and magnetism.

:bangbang: **This game is only a proof of concept and not yet performant!**

**Only feature to be implemented.*

## Progress
:squirrel: **30 %** - basic world set-up

## How to build from source
Clone the repository, open the project with Unity 2019.1.14f1 and
[punch the build button](https://media.giphy.com/media/wNlks0ID1igO4/giphy.gif).

## Development and target platforms
- **Unity 2019.1.14f1** on macOS Catalina
  - Scripting Runtime: **.NET 3.5**
  - API-Level: **.NET 2.0 Subset**
- **Visual Studio** for Mac Community v8.3.10 (build 2)
- Developed for the **[VIVE](https://www.vive.com/)**

## Logbook
**15th of January 2020** <br>
Several severe problems with the Oculus Quest occured in combination with my system.
Especially, I wasn't able to connect the headset with my MacBook Pro.
Downloading [Android Studio](https://developer.android.com/studio/index.html) didn't help either.
I watched a few tutorials on YouTube (e.g. [How to make an OCULUS QUEST game](https://www.youtube.com/watch?v=qiJpjnzW-mw)
by [Valem](https://www.youtube.com/channel/UCPJlesN59MzHPPCp0Lg8sLw). I failed successfully.

*For more information please visit the [old project](https://github.com/5ahmnm1920-mep3-G2/VRProject-vTschopp).* :link:

**22nd of January 2020** <br>
Restart of the project with the VIVE. I used a [template](https://github.com/5ahmnm1920-mep3-G2/unity-2019.1.14f1-3D-template)
to create the initial project, renamed the neccessary things and updated the README.md and .gitignore files. I also downloaded
the [SteamVR Plugin](https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647) and imported it into
the project. After that, I implemented the basic VR controls. A test with the headset was successful. :ok_man:

**28th and 29th of January 2020** <br>
I made a simple level with cubes, added the teleport feature and made a power cell prefab. Instances of this prefab
are spawning randomly on the map, controlled by a simple script in combination with two empties which define the spawn area.
I learned how to use a [slider](https://answers.unity.com/questions/186832/slider-bar-in-inspector.html) in the
Unity inspector - quite a handy feature! :cool:

**5th of February 2020** <br>
A spinning globe was added. Yeah, thats all. :rocket:


## Tutorials and Docs
- None so far.

## License
This project is licensed under the BSD 2-Clause License - see the [LICENSE.md](LICENSE.md) file for more information.

*Made with :heart: in Salzburg, Austria.*
