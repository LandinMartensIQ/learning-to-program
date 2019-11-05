# Assumptions

* You have read this assignments parent `5 - RPG` folder instructions and performed the required setup steps

# Setup Instructions

* Open `C:\Git\learning-to-program\5 - RPG\Code\RPG.sln` within Visual Studio 2019
* Create C# .NET Core project(s) to build and test your code

# Assignment #5.1 | RPG Character Builder

The goal of this specific assignment is to build a character builder from the ground up for later use in the RPG. The client is still figuring out how they want the rest of the game to work but for now they have at least given some of the requirements for this part of the game. They are not sure yet how exactly they will integrate the character builder into the game so requirements may change in the future.

**NOTE: You don't need any sort of user interface for this (not even a console window). Assume your code will be later consumed by a user interface or a console window.** *With that said, if you want, create a console program if you want to interact with your character builder for fun.*

### Character Builder Requirements

* Character Builder
	* The character builder requires the following character body attributes set before moving to the next step
		* **Character Builder Step 1 - Attributes**
			* Head Roundness
				* Support values are very round (100%) to not round at all (0%)
			* Fitness Level
				* Supported values are "extremely fit", "very fit", "somewhat fit", "not fit", "far from fit"
			* Height
				* Needs to be in inches and feet and needs to be supported like "5'11" or "5"
		* The character builder should not create a character that does not have the required attributes set
	* After the required character body attributes are set, the character builder now requires the characters ability points to be set
		* **Character Builder Step 2 - Ability Points**
			* Intelligence
				* Supported values 5 to 20
			* Wisdom
				* Supported values are 5 to 20
			* Dexterity
				* Supported values are 1 to 20
			* Strength
				* Supported values are 1 to 20
			* Charisma
				* Supported values are 0 to 20
			* Constitution
				* Supported values are 10 to 20
		* The sum of all points must be 60, no more and no less
			* So for example if each was set to 10, this is valid however if each was set to 11 or 9 this is not valid
		* The character builder should not create a character that does not have the required attributes set
	* After the required character ability points are set, if the character is valid the character builder will now build the character

* Character
	* The character should expose its ability points and body attributes however they can't be changed

# Submission Instructions

* When you are done and ready for review you need to push your changes so your mentor can see them
* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git add .` and hit enter
* Type `git commit -m "Character Builder"` and hit enter
* Type `git push` and hit enter
* Let your mentor know you are done and it is ready for review
