# Assignment #3 | Fight Club (Using OOP)

This assignment will help you understand and use object oriented code and principals (OOP). This will show you the power of interfaces and how without any code being implemented I can test expected class functionality.

# Requirements Before Starting

* Understanding of the following `(Enums, Classes, Interfaces, Properties, Methods, Functions)`
* Possibly googling how to do things in C# as you run into roadblocks - this is expected
  * Googling things and doing self research is a core aspect of being a programmer
  * If you still are having a hard time, ask me for help

# Setup Instructions

* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git checkout master` and hit enter
* Type `git pull` and hit enter
  * Checking out master and pulling the latest code starts you out on latest changes
* Type `git checkout -b <your_name_here_without_arrows>_Assignment_3` and hit enter
* Type `git push -u origin <your_name_here_without_arrows>_Assignment_3` and hit enter
* Open this folder `C:\Git\learning-to-program\3 - FightClub` in file explorer
* Open `FightClub.sln` in visual studio 2019

# Assignment Instructions

* With the project open within visual studio
* The first objective is to create a class that implements `IPowerUp` which `FightClub.cs` will return
  * Only implement enough so that the `1 - ObjectValidationTests` `PowerUp_Tests.cs` passes
* The second objective is to create a class that implements `IPotion` which `FightClub.cs` will return
  * Only implement enough so that the `1 - ObjectValidationTests` `Potion_Tests.cs` passes
* The third objective is to create a class that implements `IFighter` which `FightClub.cs` will return
  * Only implement enough so that the `1 - ObjectValidationTests` `Fighter_Tests.cs` passes
* The fith objective is to implement more of the fighter object you have created
  * Only implement enough so that the `2 - BasicFighterTests` `BasicFighter_Tests.cs` passes
* The last objective is to implement all remaining functionality
  * Only implement the remaining logic so the following tests pass:
    * `3 - FighterPotionAndPowerUpTests` `3.1 - FighterPowerUp_Tests.cs`
    * `3 - FighterPotionAndPowerUpTests` `3.2 - FighterPotion_Tests.cs`
  
# Submission Instructions

* When you are done and ready for review you need to push your changes so I can see them
* Open `Git Bash` (windows search for it)
* Type `cd C:\Git\learning-to-program` and hit enter
* Type `git add .` and hit enter
  * This will stage your all changes in your local branch
* Type `git commit -m "Assignment Changes"` and hit enter
  * This will create a commit with all the staged files in your local branch
* Type `git push` and hit enter
  * This will push your local commit(s) to your remote branch
* Let me know which assignment you have done and I will take a look and review it
