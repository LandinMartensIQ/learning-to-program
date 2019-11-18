# Assumptions

* You have read this assignments parent `5 - RPG` folder instructions and performed the required setup steps
* You have finished the previous assignment `5.1 - Character Builder` and gone through code review

# Setup Instructions

**These instructions will be different than what you normally do because you won't be starting from scratch. As you will be working off of previous work please read the instructions carefully. What the below steps will do is place you in a clean state with a new branch but keep all your code from the previous assignment.**

* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git add .` and hit enter
* Type `git stash` and hit enter
* Type `git checkout <your_name_here_without_arrows>_RPG_CharacterBuilder` and hit enter
	* This is basically the biggest change. This command is basically "start me off with the code I wrote"
* Type `git pull` and hit enter
* Type `git checkout -b <your_name_here_without_arrows>_RPG_Respec` and hit enter
* Type `git push -u origin <your_name_here_without_arrows>_RPG_Respec` and hit enter
* Open `C:\Git\learning-to-program\5 - RPG\Code\RPG.sln` within Visual Studio 2019
* You should see any project(s) and code you have created from the previous assignment

# Assignment #5.2 | RPG Respec

The goal of this specific assignment is to extend your character builder. The client wants to allow users to pay money to "respec" their character. This means that after a character is made and is finalized, there is still a way to adjust a characters ability points but only their ability points. You may refactor as much of your previous code as you would like to accomplish this change request.

### Character Builder Requirements

* Character Builder
	* A finalized character can have its ability points adjusted after the fact
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
	* After the required character ability points are set, if the character is valid the character builder will now modify the character

* Character
	* The character should still expose its ability points and body attributes however they can't be changed without going through the character builder

# Submission Instructions

* When you are done and ready for review you need to push your changes so your mentor can see them
* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git add .` and hit enter
* Type `git commit -m "Character Respec"` and hit enter
* Type `git push` and hit enter
* Let your mentor know you are done and it is ready for review