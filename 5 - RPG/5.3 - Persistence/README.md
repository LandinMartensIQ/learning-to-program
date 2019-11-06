# Assumptions

* You have read this assignments parent `5 - RPG` folder instructions and performed the required setup steps
* You have finished the previous assignment `5.2 - Respec` and gone through code review

# Setup Instructions

**These instructions will be different than what you normally do because you won't be starting from scratch. As you will be working off of previous work please read the instructions carefully. What the below steps will do is place you in a clean state with a new branch but keep all your code from the previous assignment.**

* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git add .` and hit enter
* Type `git stash` and hit enter
* Type `git checkout <your_name_here_without_arrows>_RPG_Respec` and hit enter
	* This is basically the biggest change. This command is basically "start me off with the code I wrote"
* Type `git pull` and hit enter
* Type `git checkout -b <your_name_here_without_arrows>_RPG_Persistence` and hit enter
* Type `git push -u origin <your_name_here_without_arrows>_RPG_Persistence` and hit enter
* Open `C:\Git\learning-to-program\5 - RPG\Code\RPG.sln` within Visual Studio 2019
* You should see any project(s) and code you have created from the previous assignment

# Assignment #5.2 | RPG Persistence

The goal of this specific assignment is to allow your system to **save** as well as **load** character data.

### Character Builder Requirements

* Character Saving
	* A character should only be able to be saved to disk if the character is valid and finalized
	* A character should only be able to load characters from disk if the characters are valid and finalized
	* If a character can't save or load, the system should be able to handle this without crashing

* Saving Suggestions
	* You are not limited in anyway in **how** you want to save and load a character to disk but below are some suggestions
		* Serialization
			* A common one is `https://www.newtonsoft.com/json`
		* CSV(s)
		* Custom file format that you build
	* You are not limited in anyway to **where** you want to save and load the characters from

* Technologies
	* You may need to use new **.NET libraries** that you have not used before
	* You may need to use **external libraries**, many can be imported with **Nuget**
	* If you run into problems, discuss the problem space with your mentor
		* Try to only get help when you run into roadblocks, attempt as much as you can yourself
		* It is very common to be asked to do something and have to go to google with a concept

# Submission Instructions

* When you are done and ready for review you need to push your changes so your mentor can see them
* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git add .` and hit enter
* Type `git commit -m "Character Persistence"` and hit enter
* Type `git push` and hit enter
* Let your mentor know you are done and it is ready for review