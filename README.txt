This is the final project from Carlos Muntané Fuentes and Andrea Garcia Fabregas.

We have completed tasks 1,2,3 and 5. 
All four tasks are to be found on the folders named Unity and Cinematics.

For the first task, two types of MenuItem shortcuts have been created on the script named "task_1.cs".

	1) The first task can be found on the settings of the transform of any object.
		When you select two or more objects, these can be align in all axis (X,Y,Z) through the labels called "alignX", "alignY" and "alignZ".
	2) The second tasks can be found when right-clicking on an element in the Hierarchy Menu under the label Create Other: "Select with Tag" and "Select All"
		The first one allows to select all elements in that Menu with the same tag.
		This is done selecting an object with a tag and then clicking on the option.
		If an object has no tag, this option will do nothing.
		The second one allows to select all items in the Hierarchy menu.
		This is done by right-clicking on the menu and selecting that option.

For task 2, the following has been changed in MVDTools and ClickSpawn:
	1)In MVDTools you can change the variables and assets without needing to stop the Build Mode.
		The X button restart the offset that is put on the asset.
		The R button creates a random rotation and scale for the asset.
		When editing is done, this will close and no more assets will be able to be added on the scene.

For task 3 a 3ds Max file has been created under the name SplinePath.max.
This contains 3 cameras attached to 3 different splines and linked to a 100 frame cinematic to move the camera through the spline.
One spline is shaped like an Helix, another is a 5-sided NGon and the last one is a star.
Through the maxscript files provided in the first part of the year, the scene exporter has been adapted to create a JSON file with the information needed to animate the cameras.
The tracks has also been edited in the engine so that when one is finished, it moves automatically to the next one.
When finished it will automatically go back to the first track, looping the cinematics.

-------------------------------------------------------
To start the cinematics presss only the 6-digit button
-------------------------------------------------------

For task 5, a whitebox level has been created to simulate one of the possible levels for Carlos' TFM regarding a soul trying to escape from the underworld.
To help with that a small cementery has been created as a possible final level in which the main character finally managed to escape the underworld and return to his grave in the real world (suppousedly still in spirit form).
It follows a metric system based of the unit in the ProBuilder Window. Marking the main character as 1x2x1 (x,y,z) and marking the jump hight at y=4 and making all elements in the graving at like 6 units tall, making it impossible for the spirit to jump over any element.
Ground exploration is the only option.
The paths simulate and S-curve, making most of them not follow extremely straight lines so the character will easily view the other possible paths in the level marked for exploration.
Finally all the assets in the level have been made with the ProBuilder Window as a tile set of assets which were later used and placed correctly to form the appropiate level.

Should any questions or problems arise, do not hesitate on contacting us about it.