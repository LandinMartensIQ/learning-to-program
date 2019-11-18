# Assumptions

* You have finished the previous assignment `5.2 - Respec` and gone through code review

# Setup Instructions

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
	* A character and its attributes / ability points should only be able to be saved to disk if the character is valid and finalized
	* A character should only be able to load characters and its attributes / ability points from disk if the characters are valid and finalized
	* If a character can't save or load, the system should be able to handle this without crashing (known as failing gracefully)

* Saving Suggestions
	* You are not limited in anyway in **how** you want to save and load a character to disk but below are some suggestions
		* Serialization
			* A common library for this is `https://www.newtonsoft.com/json`
		* CSV(s)
		* Custom file format that you build
	* You are not limited in anyway to **where** you want to save and load the characters from

* Technologies
	* You may need to use new **.NET libraries** that you have not used before
		* Depending on how you tackle this, you may likely need to use the System.IO library and namespace(s)
	* You may need to use **external libraries**, many can be imported with **Nuget**
	* If you run into problems, discuss the problem space with your mentor
		* Try to only get help when you run into hard roadblocks, attempt as much as you can yourself
			*  If you do end up asking your mentor, try to get help on the concept of the problem instead of how to implement and fix the problem
		* It is very common to be asked to do something and have to go to google with a concept to figure out how to implement it

# Submission Instructions

* When you are done and ready for review you need to push your changes so your mentor can see them
* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git add .` and hit enter
* Type `git commit -m "Character Persistence"` and hit enter
* Type `git push` and hit enter
* Let your mentor know you are done and it is ready for review