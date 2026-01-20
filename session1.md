# Session 1

# <a name="whatis">What is Unity? 

Unity is a tool for creating interactive experiences. It allows designers and artists to turn visual ideas, spaces, and objects into systems that react to users in real time. Instead of focusing on static images or pre-rendered animations, Unity is about interaction, movement, and behavior.

While tools like Blender are used to design and model visual elements, Unity is the place where these elements are staged, combined, and activated. In Unity, designers work with scenes, cameras, light, time, and interaction—similar to building a spatial composition that can be explored, played, or experienced.

Unity is widely used not only for games, but also for digital art, installations, simulations, and experimental projects that sit between design, technology, and performance.

### What Unity can do

Unity is good at real-time, interactive systems.

Unity can…
- Create interactive experiences
- Games (2D, 3D)
- Installations
- Simulations
- VR / AR experiences
- Prototypes and playable concepts
- Work in real time
- Immediate visual feedback
- Dynamic lighting and movement
- Interaction while the scene is running
- Handle behavior and logic
- User input (keyboard, mouse, controller, touch)
- States, triggers, events
- Physics (gravity, collisions)
- Simple AI and agent behavior
- Stage and compose spaces
- Scenes, cameras, light
- Spatial relationships
- Timing, rhythm, flow
- Integrate many media (3D models, images, video, sound,Assets from Blender, Photoshop, etc.)
- Build and export applications (Windows, macOS, Linux, Web (WebGL), Mobile, VR headsets, ...) 

### What Unity cannot (or should not) do

Unity is not a universal design tool.

Unity cannot…
- Replace creation tools
	- No proper 3D modeling (→ Blender)
	- No image editing (→ Photoshop)
	- No sound editing (→ Audition, Reaper)
	- No layout or typography tools (→ InDesign, Figma)

- Replace offline rendering -> No high-end cinematic rendering like Blender Cycles
- Limited control over frame-by-frame image perfection
- Work well for print
- Automatically support collaboration -> Collaboration must be planned and structured


# <a name="editor">Working with the Unity Editor

## General Unity Glossary

### Unity Hub
The Installer for different Unity versions and the place to open all of your Unity projects 

### Unity Editor 
The Unity programm itself, where you design your game 

### Build 
when you are finished with your game, you can export your game as a build, which means that the game can be played on different platforms without the Unity Editor. 

### Project 
The project consists of all the elements that make up your game, it is a folder on your harddrive. 

### Scenes 
Scenes are like levels in your game, each level usually is made out of one scene. In the scene you basically save how your Assets are linked to each other (how they are placed in the scene, how they interact etc.). You can have as many scenes as you like in your game and not every scene has to be in the final game. 

### Assets 
Assets are all Elements in Unity that are saved as a file on your computer. For example 3D-Objects, Materials, Scripts etc. 

### GameObjects
GameObjects are the virtual objects in your Unity Scene, they are not saved as a file in your assets folder, but they only exist within the scene. (If you want to create an Assets out of a GameObject you can create a PreFab.) 

### Component 
Components are the functional pieces of every GameObject. Each GameObject is made out of different components, e.g. the "Mesh Renderer" tells Unity that this is an object that should be rendered (should be visible) in the scene. 

## Unity Editor User Interface

![](images/UnityUI.jpg)

### 1. Project windows: 
- a file explorer, where you can find all of your assets 
- Unity projects are always a folder consisting of different file types (in contrast to e.g. a Blender file). That means if you press save, you only save the current scene, the rest of your project in saved in the folder. 

> Data backups: always duplicate the entire folder, ideally always copy the entire folder before making major changes. Alternatively: Use a version control system like git. 

### 2. Hierarchy
- In the Hierarchy you can find all the GameObjects that are in your currently opened scene
- Here you can also see how the objects are arranged hierarchically (Parent-Child)

### 3. Inspector
- shows you all the Components that are part of the current GameObject when you select a GameObject
- also shows you the properties of all the Assets when you select an Assets
- allows you to change the properties of the different Components & Assets

### 4. Scene View 

![](images/SceneView.jpg)

- Displays the current 3D scene
- Move with: 
	- Rotate: option + mouse click
	- Move: option + command + mouse click
	- Zoom: Two finger scroll 
	- double-click on object: focus on object 
- Use the Scene Gizmo (a) to switch to a single axis view 
- You can switch between 2D & 3D view (b) (helpful for UI work)
- You can change the perspective mode (c)
- Toggle visibily of gizmos (d)
- Tools to move/rotate/scale objects (e)


### 5. Game View 
- shows the game as it will look later when the player will play it
- if you press "Play" at the top of the screen, a preview of how the game will look later is displayed here 
- here you can preview the game in different screen sizes etc. 
- most of the animations/scripts etc. only run when you have pressed play

### 6. Toolbar 
- Control the Game Mode of the current scene

### 7. Menubar
- can be used to create Assets, GameObjects, change the window-arrangement, save the current scene etc. 

You can find a Cheat Sheet with the Basic Unity UI Elements here: 
https://github.com/juliannetzer/arfoundation-demos_khb_sose22/blob/master/Handouts/220501_UnityCheatsheet.pdf

## Further tutorials for getting started in Unity: 
- [Everest Pipkin: Quickstart Unity 3d ](https://docs.google.com/document/d/1xwGpjgIRhZAqprW-jECGN1WNh_o2jfO_84hjLQ59TIQ/edit)
- [Brackeys: How to make a Video Game - Getting Started](https://www.youtube.com/watch?v=j48LtUkZRjU&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6)
- [Ray Wenderlich: Unity Getting started](https://www.kodeco.com/7514-introduction-to-unity-getting-started-part-1-2)
- [The Ultimate Beginner Guide to Unity](https://www.freecodecamp.org/news/the-ultimate-beginners-guide-to-game-development-in-unity-f9bfe972c2b5/)


# <a name="structure"></a> How to structure your unity projects
Since Unity projects quickly get very messy it is important to structure your assets & scenes, you can find some useful information here: 

[Best practices of organizing your unity project](https://unity.com/how-to/organizing-your-project)

# <a name="basic3d"></a> Basic 3D Objects

Unity has a few builtin basic 3D Models, like Cubes, Planes, etc. 

You can find them under GameObject -> 3D Object
![](images/models.jpeg)

> You can also use these simple 3D Objects to build complex scenes, for example when using quads as surfaces and then apply a texture to it you can build simple 2.5D-worlds like [here](https://vk-showcase.kh-berlin.de/project/whomans).

# <a name="materials"></a> Materials/ Shaders/ Textures 

Every 3D-Assets in Unity needs a material that is attached to it, and every material needs a shader. The material is the place where the information like colors and textures are stored. The shader then tells unity how to render these information. (you can compare it to using a pencil: the material stores the color, the shader stores whether it is a wax crayon or a colored pencil). 

Most materials have a certain set of textures (images) applied. The most important ones in Unity are: 

- Albedo/Base Map: The main color texture that defines the basic surface appearance and color of a material. It represents how the surface looks under pure white light without any lighting effects.
- Specular Map: Controls the shininess and highlight intensity across different parts of the surface. Bright areas in the map appear more reflective/shiny, while dark areas appear more matte.
- Normal Map: Adds detailed surface bumps and wrinkles without requiring extra geometry. It stores surface angle deviations in RGB channels, creating the illusion of intricate surface detail through light interaction.
- Height Map: Creates parallax effects by simulating surface depth. Lighter areas appear raised while darker areas appear sunken, adding depth perception when viewing the surface at angles.
- Occlusion Map: Represents how much ambient light reaches different parts of the surface. Dark areas receive less ambient light, enhancing the perception of crevices and adding depth to surface details.

## Create a new material: 

Click on Assets -> Create -> Material

Now you can add some textures and change the colors. 
To apply the material to an object, just drag and drop it onto the object. 

## Shaders 
Shaders are small programs that determine how objects appear in a 3D scene by controlling how surfaces interact with light and textures. They are used to define visual effects like colors, reflections, transparency, and more. Unity uses shaders to create realistic or stylized materials, enabling a wide range of visual styles for your projects. 

The most important ones for you are: 
- Lit: The standard shader with all the standard settings, is affected by your scene lighing
- Unlit: Minimal shader, that is not effected by lighting. 

You can find the shaders by clicking on: 
![](images/shader1.jpeg)
![](images/shader2.jpeg)
![](images/shader3.jpeg)

## Working with Transparency
To work with transparency you can either select a shaders that directly supports transcparency (e.g. Unlit -> Transparency) or you can change the render setting of your shader, in case of the Lit shader like this: 
![](images/shader4.jpeg)

Also make sure to change the Transparency-Setting when importing your texture/image (see also in "Checking the Import settings")
![](images/shader5.jpeg)

## Textures

## Places to get free Textures: 
- [Polyhaven](https://polyhaven.com/textures)
- [Unity Asset Store](https://assetstore.unity.com/?category=2d%2Ftextures-materials&free=true&orderBy=1)
- [AmbientCG](https://ambientcg.com/)

### Settings for Polyhaven: 

- Resolution: 2K (or on better machine, or complex textures 4K)
- ZIP 
- .JPGs (or for better quality .PNG)

Conversion Table for using Polyhaven Materials: 
| Unity            | Polyhaven   |
| ---------------- | ----------- |
| Albedo/ Base Map | Diffuse     |
| Specular Map     | Spec        |
| Normal Map       | Normal (GL) |
| Height Map       | Displacement|
| Occlusion Map    | AO          |

## Checking the Import settings

1. Select the file
In the Project window, click once on the imported file (for example a texture or a 3D model).

2. Look at the Inspector
On the right side of the Unity interface, you will see the Inspector.
This panel shows the Import Settings of the selected file.
![](images/importsettings2.jpeg)


3. Check the important options: 

- Alpha is Transparency turned on, when you work with transparency
- When you don't work with square images: Advanced -> Non-Power of 2 -> None
> Square textures (for example 512×512 or 1024×1024 pixels) work best in Unity because they are more efficient for real-time rendering. Unity and graphics hardware are optimized for these sizes, which helps improve performance and avoids technical issues. However, non-square textures can also be used if needed.

4. Apply changes
If you change any setting, always click Apply at the bottom of the Inspector.
Otherwise, Unity will not update the file.

## Importing your own textures into Unity

1. Prepare the texture
Create your texture in an external tool such as Photoshop, GIMP, or Substance Painter.
It is recommended to use a square texture (e.g. 512×512, 1024×1024, 2048×2048 pixels), as this works best with real-time rendering and performance.
Save the file as PNG or JPG (PNG is recommended for transparency).

2. Import into Unity
Drag the image file into the Assets folder of your Unity project.
Unity will automatically import the texture.

3. Check the import settings
Select the texture in the Project window and adjust the settings in the Inspector (Texture Type, Max Size, Compression), then click Apply.

4. Create or assign a material
Create a Material and drag the texture into the Albedo / Base Map slot.

5. Apply to an object
Drag the material onto a 3D object in the Scene or Hierarchy to see the texture in real time.


# <a name="3dassets"></a> Working with imported 3D Assets
![](images/assets.jpeg)

Most of the times the 3D-Assets are generated outside of Unity and then imported into the project.

**Supported 3D File Formats**

Unity supports various 3D model formats, including:

- FBX (.fbx) – Recommended for compatibility and animation support.
- OBJ (.obj) – Common for static models but does not support animations.
- GLTF/GLB (.gltf, .glb) – Optimized for web and real-time rendering.
- Unity-native files – Blender (.blend) files can be imported directly, but it is recommended to export them as FBX for better control.

**Importing Assets into Unity**

There are multiple ways to import 3D assets into your Unity project:
Method 1: Drag and Drop (Quick and Easy)

- Open the Project Window in Unity.
- Locate the Assets folder (or a subfolder like Models if you have one).
- Drag your 3D model file from your file explorer (Windows/Mac) directly into the Assets window.
- The asset will now appear in your Unity project and can be placed in a scene.

Method 2: Using the Unity Import Menu (For Better Control)

- In Unity, go to Assets → Import New Asset...
- Select the 3D model file you want to import.
- Click Import to add the asset to your project.

**Adjusting Import Settings**

Once imported, select the 3D model in the Project Window, and check the Inspector panel to adjust settings such as:

- Scale Factor – Ensures the model is properly scaled in Unity.
- Normals & Tangents – Controls how lighting interacts with the model.
- Materials & Textures – Ensures textures are correctly applied if they were included in the export. (details in the section Troubleshooting below)
- Rig & Animation Settings – If the model includes a rig or animations, configure them under the Rig and Animation tabs. (we will have a look at this in session 2)
[Unity Documentation on file formats](https://docs.unity3d.com/2020.1/Documentation/Manual/3D-formats.html)


## Best places to get free 3D-Assets 

- [Unity Asset Store](https://assetstore.unity.com/?category=3d%2Fenvironments&free=true&orderBy=1): Large library of assets, specifically for unity, sometimes with animations 
- [Sketchfab](https://sketchfab.com): Large library for free Assets, also from museums etc., mixed quality & licenses 
- [Mixamo](https://www.mixamo.com/): Large library of (mostly) humanoid Avatars & Animations
- [Polyhaven](https://polyhaven.com/models): Not that many models, but all can be used for any purpose (commercial and personal)
- [Everything library](https://davidoreilly.itch.io/): library of objects from the (very good) game "Everything", see hint below, a lot of models, all in the same style (low poly), can be used in all projects, but an attribution is necessary[license](https://creativecommons.org/licenses/by/4.0/)
- [NASA 3D Models](https://nasa3d.arc.nasa.gov/models): library of space related objects, different quality, but some are quiet nice
- [Three D Scans](https://threedscans.com/): library of 3d scanned statues & some animals, very detailed 
- [ArtStation](https://www.artstation.com/marketplace/game-dev/assets?section=free): Plattform, mixed quality, different
- [Quaternius](https://quaternius.com/): nice low poly packs, most of them free to use
- [OpenGameArt](https://opengameart.org/art-search-advanced?keys=&field_art_type_tid%5B%5D=10&sort_by=count&sort_order=DESC): a lot, mixed quality
- [Dimensiva](https://dimensiva.com/free-3d-models/): mostly furniture

> Trees are rather difficult to render in Unity, so either use Low-Poly Versions, or you can also find some in the Assets Store (e.g. [Realistic Pines](https://assetstore.unity.com/packages/3d/vegetation/trees/realistic-pine-tree-pack-232166), [Polygon Trees](https://assetstore.unity.com/packages/3d/vegetation/trees/polygon-trees-224068))

### Using Everything Models 

To use the Everything Models: 
1. download this shader: [VertexLitShader](Assets/VertexColorLit.shader) (go to "Download Raw File")
![](images/everything.jpeg)
2. Drag and Drop the shader in your Unity Project Window
3. Create a new material -> Drag and Drop the shader on this Material
4. Apply this material to the everything Model in your scene 

##  <a name="onlinetools"></a> Online Sculpting Tools

### SculptGL 
![](images/sculptgl.jpeg)

An  WebGL-based sculpting application that enables users to create and refine 3D models directly in their browser.
[Link](https://stephaneginier.com/sculptgl/)

When using this tool, please set the resolution to 3: 
![](images/sculptgl2.jpeg)

### MonsterMash
![](images/monstermesh.jpeg)
A sketch-based modeling and animation tool that allows users to draw 2D characters, inflate them into 3D models, and animate them.
[Link](https://monstermash.zone/)

## AI Tools

### Lumalabs Genie
![](images/lumalabsgenie.jpeg)
A platform designed to generate 3D models from text and images.
[Link](https://lumalabs.ai/genie?view=create)

## Install .glb Plugin	
Since Lumalabs uses the .glb-fileformat we have to install a plugin in Unity first, for this follow these steps: 
Go to https://github.com/Siccity/GLTFUtility and click on "Code" -> "Download ZIP"
![](images/glb1.jpeg)

Then extract and .zip-file and go back to Unity. Click on "Window" -> "Package Manager"
![](images/glb2.jpeg)

Click on the + and select "Add package from disk"
![](images/glb3.jpeg)

Then find your extracted .zip-file and open the "package.json"-file. 
![](images/glb4.jpeg)

Now you should be able to open the models from Lumalabs.

### Hyper3D 
![](images/hyper3d.jpeg)
An AI-powered 3D model generator that creates 3D assets from text and images.
- [Hyper3D - Rodin](https://hyper3d.ai/)

## Troubleshooting

### Material is displayed pink: 
Probably a problem with the renderpipeline, find the material in the project window, select it and then click on "Edit -> Rendering -> Materials -> Convert Selected Built-in Materials to URP". If this does not work, either create a new material and assign it, or if you can get the asset in a different fileformat try that. 

### Imported object does not have a color/texture 
- See whether the asset comes with a "material" or "texture" folder, if yes, try: 
	- select the 3D-model in the project window, and go to the "Materials"-Tab in the Inspector window, select Location -> Use External Materials (Legacy) and click "Apply"
	- If this does not work: switch to Location -> Use Embedded Materials again and click on "Extract Materials" and then on "Apply". This extract the Materials from the model and you can manually assign the textures/colors etc. 
- If it does not come with an extra folder: 
	- select the asset in the Project window and click on "Extract Textures" and/or "Extract Materials" in the Inspector (in the "Materials" Tab)
	-  If there are still no materials/textures you have to manually create them/ or find a new asset

# <a name="perfomance"></a>Performance?

Especially when choosing the 3D assets and lights, you should have in mind where your scene will be played in the end, e.g. as desktop VR, i.e. on a powerful computer, or in mobile VR (e.g. an Oculus Quest). As all devices only have a limited performance capacity.

To reduce the triangles of an object, you can use a 3D-modelling-software like blender, you can find more information here: 
[Simplify a Mesh in Blender](https://all3dp.com/2/blender-simplify-mesh-simply-explained/)


# <a name="light"></a>Lighting the Scene
![](images/lights.jpeg)

## Realtime Lights 
Realtime lights calculate the lightrays in realtime, that means you can move the lights, move the object that catch shadows from the light without any prerendering. 

You can find them under GameObjects -> Light
![](images/lights1.jpeg)

There are three types of lights: Spotlight, Pointlight, Directional light. 

#### Spotlight
A Spotlight emits light in a cone shape, illuminating only a specific area in a particular direction. It's ideal for focused lighting, like flashlights, spotlights on a stage, or headlights on a vehicle. You can adjust the cone angle and range to control its spread.

#### Point Light
A Point Light emits light uniformly in all directions from a single point, similar to a light bulb. It's perfect for creating localized illumination, such as a lamp, a torch, or glowing orbs. You can adjust its range to control how far the light reaches.

#### Directional Light
A Directional Light emits light evenly across the entire scene, simulating sunlight or moonlight. It has no specific source position and affects all objects as though light rays are parallel. It's commonly used for outdoor scenes or large-scale environments.

You can also change parameters like intensity, color etc. when you select the light in your scene or in your hierarchy: 
![](images/lights2.jpeg)



## Skyboxes 
A Skybox is a panoramic background that surrounds your entire scene, simulating the appearance of a distant environment, such as a sky, stars, or a landscape. It's implemented as a textured sphere or cube that wraps around the scene and serves as both a visual backdrop and a source of ambient lighting. By using a Skybox, you can easily change the atmosphere and lighting of your scene.

To use a skybox go the lighting window (Window -> Rendering -> Lighting) and select the skybox material: 
![](images/skyboxlighting.jpeg)

(Note: You have to click on "Generate Lighting" and your Objects need to be static)

Best places to find skyboxes: 
- [Polyhaven](https://polyhaven.com/hdris)
- [Unity Asset Store](https://assetstore.unity.com/2d/textures-materials/sky)

### Importing a skybox (from Polyhaven)
Download the skybox as .exr (i would recommend 4k resolution, if you wanna see the skybox in the background, if not 1k should be enough). 

Import to Assets, then select the image in the Project Window and go to the inspector and select texture shape -> 
![](images/importsettings.jpeg)

Then create a material (Assets -> Create -> Material) go the inspector and search for "Cubemap" in the shader dropdown. 
![](images/skyboxmaterial.jpeg)

Then you can drag and drop the image that you imported in the cubemap area. 
![](images/skyboxmaterial2.jpeg)

Now you can use the skybox in the lighting settings. 

# <a name="terrain"></a>Terrain Tool  
![](images/terraintools.jpeg)
With the Terrain Tool, you can very easily create landscapes and add vegetation. 

To create a Terrain go to: GameObject -> 3D Object -> Terrain 

To now change the height of the Terrain select the Terrain and select the Raise or Lower Terrain Brush: 
![](images/terrain1.jpeg)

To Paint a Texture select the "Paint Texture" Brush: 
![](images/terrain2.jpeg)
Then create a new Layer and choose a texture:  
![](images/terrain3.jpeg)
And select with which Layer you want to draw: 
![](images/terrain4.jpeg)

You can find a good tutorial here: 
[How to build beautiful landscapes in Unity using Terrain Tools | Tutorial](https://www.youtube.com/watch?v=smnLYvF40s4)


## <a name="workingtogether">Working together with Unity 

To work together in Unity you can either work from on file (e.g. on an external drive) or you can split the work: Person 1 works on the world, Person 2 on the models/materials etc. 

To merge project the easiest way is to work in one main project and then create packages to transfer your Objects or files. 

## Creating your package for sharing

To create your own package go to Assets -> Export Package 
![](images/packagemanagerexport1.jpeg)

Then you can select the Assets that you want to include.
![](images/packagemanagerexport2.jpeg)
If you now click on Export it will export your files as .unitypackage-file. 

If you want to include Assets from only one scene you can first select your scene in the Project window, right click on it and click on "Select dependencies": 
![](images/packagemanagerexport3.gif)
When you now click on Assets -> "Export Package" Unity will only include the Assets from the scene that you selected. 

## Importing costum packages
To import a package (like the one you created earlier) click on Assets -> Import Package -> Costum Package
![](images/packagemanagerexport4.jpeg)


